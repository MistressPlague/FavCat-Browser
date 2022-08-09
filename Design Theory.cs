using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FavCat_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (var i = 0; i < 15; i++)
            {
                var clone = FavCategoryBG.Clone();
                LayoutPanel.Controls.Add(clone, 0, LayoutPanel.RowCount - 1);

                LayoutPanel.RowCount++;
                LayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
        }
    }

    public static class ControlExtensions
    {
        public static List<Control> ToList(this Control.ControlCollection col)
        {
            var list = new List<Control>();

            foreach (Control c in col)
            {
                list.Add(c);
            }

            return list;
        }

        private static int CloneNum = 1;
        private static List<string> ClonedNames = new ();

        public static T Clone<T>(this T controlToClone, string NameOverride = null, Control ParentOverride = null, bool OnlyCloneByNameOnce = true) where T : Control
        {
            if (OnlyCloneByNameOnce)
            {
                if (ClonedNames.Contains(controlToClone.Name))
                {
                    return null;
                }

                ClonedNames.Add(controlToClone.Name);
            }

            var instance = Activator.CreateInstance<T>();

            instance.Name = string.IsNullOrEmpty(NameOverride) ? controlToClone.Name + "_Clone_" + CloneNum : NameOverride.Replace("<num>", CloneNum.ToString());

            (ParentOverride ?? controlToClone.Parent).Controls.Add(instance);

            instance.BackgroundImage = controlToClone.BackgroundImage;
            instance.BackgroundImageLayout = controlToClone.BackgroundImageLayout;
            instance.Location = controlToClone.Location;
            instance.Size = controlToClone.Size;
            instance.AutoSize = controlToClone.AutoSize;
            instance.Anchor = controlToClone.Anchor;
            instance.AllowDrop = controlToClone.AllowDrop;
            instance.ContextMenu = controlToClone.ContextMenu;
            instance.ContextMenuStrip = controlToClone.ContextMenuStrip;
            instance.Padding = controlToClone.Padding;
            instance.RightToLeft = controlToClone.RightToLeft;
            instance.Font = controlToClone.Font;
            instance.Text = controlToClone.Text;
            instance.Dock = controlToClone.Dock;
            instance.Tag = controlToClone.Tag;

            if (instance is Label labelClone && controlToClone is Label labelToClone)
            {
                labelClone.TextAlign = labelToClone.TextAlign;

                //MessageBox.Show($"Label Found: {instance.Name}");
            }

            #region Outdated Reflection Code
            //var controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //foreach (var propInfo in controlProperties)
            //{
            //    if (propInfo.CanWrite)
            //    {
            //        if (propInfo.Name != "WindowTarget" && propInfo.Name != "BackColor" && propInfo.Name != "ForeColor" && propInfo.Name != "Controls")
            //        {
            //            propInfo.SetValue(instance, propInfo.GetValue(controlToClone));
            //        }
            //    }
            //}
            #endregion

            instance.SetControlStyle(ControlStyles.SupportsTransparentBackColor, true);

            instance.ForeColor = controlToClone.ForeColor;

            instance.BackColor = Color.FromArgb(controlToClone.BackColor.A, controlToClone.BackColor.R, controlToClone.BackColor.G, controlToClone.BackColor.B);

            foreach (Control subcontrol in controlToClone.Controls)
            {
                if (subcontrol is Label label)
                {
                    label.Clone(null, instance);
                }
                else if (subcontrol is FlowLayoutPanel flowpanel)
                {
                    flowpanel.Clone(null, instance);
                }
                else if (subcontrol is Panel panel)
                {
                    panel.Clone(null, instance);
                }
                else
                {
                    subcontrol.Clone(null, instance);
                }
            }

            CloneNum++;

            return instance;
        }

        public static bool GetControlStyle(this Control control, ControlStyles flags)
        {
            return ((bool?)control.GetType().GetMethod("GetStyle", BindingFlags.NonPublic | BindingFlags.Instance)?.Invoke(control, new object[] { flags })) ?? false;
        }

        public static void SetControlStyle(this Control control, ControlStyles flag, bool value)
        {
            control.GetType().GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.Instance)?.Invoke(control, new object[]{ flag, value });
        }
    }
}
