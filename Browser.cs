using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FavCat.Database.Stored;
using Libraries;
using LiteDB;
using Newtonsoft.Json;

namespace FavCat_Browser
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private LiteDatabase StoreDB;
        private LiteDatabase FavsDB;

        private Dictionary<string, object> ButtonAssoc = new();

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StoreDB = new LiteDatabase(openFileDialog1.FileName);
                FavsDB = new LiteDatabase(openFileDialog1.FileName.Replace("store.db", "favs.db"));

                LoadContents();

                MessageBox.Show("Done!");
            }
        }

        private static readonly int MaxEntries = 500;

        private HttpClient client = new ();

        private void LoadContents(int Offset = 0)
        {
            ButtonAssoc.Clear();

            flowLayoutPanel1.Enabled = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Dispose();
            }

            flowLayoutPanel1.Controls.Clear();

            if (worldsToolStripMenuItem.Checked)
            {
                var Worlds = StoreDB.GetCollection<StoredWorld>("worlds").Find(o => true, Offset);

                Button NextButton = null;

                foreach (var entry in Worlds)
                {
                    Application.DoEvents();

                    if (!string.IsNullOrEmpty(entry.ThumbnailUrl))
                    {
                        try
                        {
                            using var client = new WebClient();

                            client.DownloadDataAsync(new Uri(entry.ThumbnailUrl));

                            client.DownloadDataCompleted += (_, b) =>
                            {
                                if (flowLayoutPanel1.Controls.Count >= MaxEntries)
                                {
                                    if (NextButton == null)
                                    {
                                        NextButton = new Button
                                        {
                                            BackgroundImageLayout = ImageLayout.Stretch,
                                            TextAlign = ContentAlignment.MiddleCenter,
                                            Size = new Size(162, 162),
                                            FlatStyle = FlatStyle.Flat,
                                            ForeColor = Color.Green,
                                            BackColor = Color.Black,
                                            Text = "Next Page"
                                        };

                                        toolTip1.SetToolTip(NextButton, "Current Offset: " + flowLayoutPanel1.Controls.Count);

                                        NextButton.Click += (_, _) => { LoadContents(Offset + flowLayoutPanel1.Controls.Count); };

                                        flowLayoutPanel1.Controls.Add(NextButton);
                                    }

                                    return;
                                }

                                try
                                {
                                    var image = Image.FromStream(new MemoryStream(b.Result));

                                    var button = new Button
                                    {
                                        BackgroundImageLayout = ImageLayout.Stretch,
                                        TextAlign = ContentAlignment.BottomCenter,
                                        Size = new Size(162, 162),
                                        FlatStyle = FlatStyle.Flat,
                                        ForeColor = entry.Platform.Contains("windows") ? Color.Magenta : Color.Yellow,
                                        BackColor = Color.Black,
                                        BackgroundImage = image,
                                        Text = entry.Name,
                                    };

                                    button.Click += button1_Click;

                                    flowLayoutPanel1.Controls.Add(button);

                                    ButtonAssoc[button.Name] = entry;
                                }
                                catch
                                {
                                }
                            };
                        }
                        catch
                        {

                        }
                    }

                    if (flowLayoutPanel1.Controls.Count >= MaxEntries && NextButton == null)
                    {
                        NextButton = new Button
                        {
                            BackgroundImageLayout = ImageLayout.Stretch,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Size = new Size(162, 162),
                            FlatStyle = FlatStyle.Flat,
                            ForeColor = Color.Green,
                            BackColor = Color.Black,
                            Text = "Next Page"
                        };

                        toolTip1.SetToolTip(NextButton, "Current Offset: " + Offset);

                        NextButton.Click += (_, _) =>
                        {
                            LoadContents(Offset + flowLayoutPanel1.Controls.Count);
                        };

                        flowLayoutPanel1.Controls.Add(NextButton);

                        break;
                    }
                }
            }
            else if (avatarsToolStripMenuItem.Checked)
            {
                var Faved = FavsDB.GetCollection<StoredFavorite>("Avatar_favorites").FindAll();

                var AviCol = StoreDB.GetCollection<StoredAvatar>("avatars");

                var Avatars = Faved.Select(o => AviCol.FindById(o.ObjectId));

                Button NextButton = null;

                void MakeNext()
                {
                    if (NextButton == null)
                    {
                        NextButton = new Button
                        {
                            BackgroundImageLayout = ImageLayout.Stretch,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Size = new Size(162, 162),
                            FlatStyle = FlatStyle.Flat,
                            ForeColor = Color.Green,
                            BackColor = Color.Black,
                            Text = "Next Page"
                        };

                        toolTip1.SetToolTip(NextButton, "Current Offset: " + Offset);

                        NextButton.Click += (_, _) => { LoadContents(Offset + flowLayoutPanel1.Controls.Count); };

                        flowLayoutPanel1.Controls.Add(NextButton);
                    }
                }

                foreach (var entry in Avatars)
                {
                    Application.DoEvents();

                    if (entry == null)
                    {
                        continue;
                    }

                    var ImageURL = !string.IsNullOrEmpty(entry.ThumbnailUrl) ? entry.ThumbnailUrl : entry.ImageUrl;

                    if (!string.IsNullOrEmpty(ImageURL))
                    {
                        try
                        {
                            if (flowLayoutPanel1.Controls.Count >= MaxEntries)
                            {
                                MakeNext();

                                break;
                            }

                            Task.Run(async () =>
                            {
                                try
                                {
                                    var data = await client.GetByteArrayAsync(new Uri(ImageURL));

                                    MainThreadActionsToCall.Add(() =>
                                    {
                                        try
                                        {
                                            if (flowLayoutPanel1.Controls.Count >= MaxEntries)
                                            {
                                                client.CancelPendingRequests();

                                                MakeNext();

                                                return;
                                            }

                                            var image = (Bitmap)Image.FromStream(new MemoryStream(data));

                                            var button = new Button
                                            {
                                                BackgroundImageLayout = ImageLayout.Stretch,
                                                TextAlign = ContentAlignment.BottomCenter,
                                                Size = new Size(162, 162),
                                                FlatStyle = FlatStyle.Flat,
                                                ForeColor = entry.Platform.Contains("windows") ? Color.Magenta : Color.Yellow,
                                                BackColor = Color.Black,
                                                BackgroundImage = image,
                                                Text = entry.Name,
                                            };

                                            button.Click += button1_Click;

                                            flowLayoutPanel1.Controls.Add(button);

                                            ButtonAssoc[button.Name] = entry;
                                        }
                                        catch
                                        {
                                            
                                        }
                                    });
                                }
                                catch// (Exception ex)
                                {
                                    //MessageBox.Show(ex.ToString());
                                }
                            });
                        }
                        catch
                        {
                            
                        }
                    }

                    if (flowLayoutPanel1.Controls.Count >= MaxEntries && NextButton == null)
                    {
                        MakeNext();

                        break;
                    }
                }
            }
            else if (socialToolStripMenuItem.Checked)
            {
                var Players = StoreDB.GetCollection<StoredPlayer>("players").Find(o => true, Offset);

                Button NextButton = null;

                foreach (var entry in Players)
                {
                    Application.DoEvents();

                    if (!string.IsNullOrEmpty(entry.ThumbnailUrl))
                    {
                        try
                        {
                            using var client = new WebClient();

                            client.DownloadDataAsync(new Uri(entry.ThumbnailUrl));

                            client.DownloadDataCompleted += (_, b) =>
                            {
                                if (flowLayoutPanel1.Controls.Count >= MaxEntries)
                                {
                                    if (NextButton == null)
                                    {
                                        NextButton = new Button
                                        {
                                            BackgroundImageLayout = ImageLayout.Stretch,
                                            TextAlign = ContentAlignment.MiddleCenter,
                                            Size = new Size(162, 162),
                                            FlatStyle = FlatStyle.Flat,
                                            ForeColor = Color.Green,
                                            BackColor = Color.Black,
                                            Text = "Next Page"
                                        };

                                        toolTip1.SetToolTip(NextButton, "Current Offset: " + flowLayoutPanel1.Controls.Count);

                                        NextButton.Click += (_, _) => { LoadContents(Offset + flowLayoutPanel1.Controls.Count); };

                                        flowLayoutPanel1.Controls.Add(NextButton);
                                    }

                                    return;
                                }

                                try
                                {
                                    var image = Image.FromStream(new MemoryStream(b.Result));

                                    var button = new Button
                                    {
                                        BackgroundImageLayout = ImageLayout.Stretch,
                                        TextAlign = ContentAlignment.BottomCenter,
                                        Size = new Size(162, 162),
                                        FlatStyle = FlatStyle.Flat,
                                        ForeColor = Color.Magenta,
                                        BackColor = Color.Black,
                                        BackgroundImage = image,
                                        Text = entry.Name,
                                    };

                                    button.Click += button1_Click;

                                    flowLayoutPanel1.Controls.Add(button);

                                    ButtonAssoc[button.Name] = entry;
                                }
                                catch
                                {
                                }
                            };
                        }
                        catch
                        {
                            
                        }
                    }

                    if (flowLayoutPanel1.Controls.Count >= MaxEntries && NextButton == null)
                    {
                        NextButton = new Button
                        {
                            BackgroundImageLayout = ImageLayout.Stretch,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Size = new Size(162, 162),
                            FlatStyle = FlatStyle.Flat,
                            ForeColor = Color.Green,
                            BackColor = Color.Black,
                            Text = "Next Page"
                        };

                        toolTip1.SetToolTip(NextButton, "Current Offset: " + Offset);

                        NextButton.Click += (_, _) =>
                        {
                            LoadContents(Offset + flowLayoutPanel1.Controls.Count);
                        };

                        flowLayoutPanel1.Controls.Add(NextButton);

                        break;
                    }
                }
            }

            flowLayoutPanel1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                var Assoc = ButtonAssoc[button.Name];

                if (Assoc is StoredWorld World)
                {
                    var json = JsonConvert.SerializeObject(World, Formatting.Indented);

                    if (MessageBox.Show(json + "\r\n\r\nDo You Want To Copy This Info To Your Clipboard?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Clipboard.SetText(json);
                    }

                }
                else if (Assoc is StoredAvatar Avatar)
                {
                    var json = JsonConvert.SerializeObject(Avatar, Formatting.Indented);

                    if (MessageBox.Show(json + "\r\n\r\nDo You Want To Copy This Info To Your Clipboard?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Clipboard.SetText(json);
                    }
                }
                else if (Assoc is StoredPlayer Player)
                {
                    var json = JsonConvert.SerializeObject(Player, Formatting.Indented);

                    if (MessageBox.Show(json + "\r\n\r\nDo You Want To Copy This Info To Your Clipboard?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Clipboard.SetText(json);
                    }
                }
            }
        }

        private void worldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            worldsToolStripMenuItem.Checked = true;
            avatarsToolStripMenuItem.Checked = false;
            socialToolStripMenuItem.Checked = false;

            LoadContents();
        }

        private void avatarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            worldsToolStripMenuItem.Checked = false;
            avatarsToolStripMenuItem.Checked = true;
            socialToolStripMenuItem.Checked = false;

            LoadContents();
        }

        private void socialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            worldsToolStripMenuItem.Checked = false;
            avatarsToolStripMenuItem.Checked = false;
            socialToolStripMenuItem.Checked = true;

            LoadContents();
        }

        private void avatarsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Worlds.json", JsonConvert.SerializeObject(StoreDB.GetCollection<StoredWorld>("worlds").FindAll()));

            MessageBox.Show("Done! Exported As \"Worlds.json\"!");
        }

        private void avatarsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Avatars.json", JsonConvert.SerializeObject(StoreDB.GetCollection<StoredAvatar>("avatars").FindAll()));

            MessageBox.Show("Done! Exported As \"Avatars.json\"!");
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Players.json", JsonConvert.SerializeObject(StoreDB.GetCollection<StoredPlayer>("players").FindAll()));

            MessageBox.Show("Done! Exported As \"Players.json\"!");
        }

        public class VRCTrackerConfig
        {
            public VRCTrackerAvatar[] selectedAvatars;
            public VRCTrackerNote[] selectedNotes;
            public VRCTrackerPlayer[] selectedUsers;
            public VRCTrackerWorld[] selectedWorlds;
        }

        public class VRCTrackerAvatar
        {
            public string authorId;
            public string authorName;
            public DateTime created_at;
            public string description;
            public string id;
            public string ImageUrl;
            public bool isMobileAccessible;
            public bool isPCAccessible;
            public string name;
            public string releaseStatus;
            public string thumbnailImageUrl;
            public string version;
        }

        public class VRCTrackerNote
        {
            public string id;
            public string note;
        }

        public class VRCTrackerPlayer
        {
            public string currentAvatarImageUrl;
            public string currentAvatarThumbnailImageUrl;
            public string displayName;
            public string id;
            public string statusDescription;
            public string[] tags;
            public string trackingType = "OFF";
            public string username;
        }

        public class VRCTrackerWorld
        {
            public string authorId;
            public string authorName;
            public string capacity;
            public DateTime created_at;
            public string description;
            public string heat;
            public string id;
            public string ImageUrl;
            public string name;
            public string popularity;
            public string[] tags;
            public string thumbnailImageUrl;
            public DateTime updated_at;
            public string visits;
        }

        private void vRCTrackerExportOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Worlds = StoreDB.GetCollection<StoredWorld>("worlds").FindAll();
            var Avatars = StoreDB.GetCollection<StoredAvatar>("avatars").FindAll();
            var Players = StoreDB.GetCollection<StoredPlayer>("players").FindAll();

            var TrackerAppConfig = new VRCTrackerConfig();

            TrackerAppConfig.selectedAvatars = Avatars.Select(o => new VRCTrackerAvatar
            {
                authorId = o.AuthorId,
                authorName = o.AuthorName,
                created_at = o.CreatedAt,
                description = o.Description,
                id = o.AvatarId,
                ImageUrl = o.ImageUrl,
                isMobileAccessible = o.Platform.Contains("")
            }).ToArray();
        }

        private void Browser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Safari/537.36");
        }

        private List<Action> MainThreadActionsToCall = new();
        private bool TimerLock = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TimerLock)
            {
                return;
            }

            TimerLock = true;

            Text = "FavCat Browser: " + flowLayoutPanel1.Controls.Count;

            if (MainThreadActionsToCall.Count > 0)
            {
                MainThreadActionsToCall[0]?.Invoke();
                MainThreadActionsToCall.RemoveAt(0);
            }

            TimerLock = false;
        }
    }
}