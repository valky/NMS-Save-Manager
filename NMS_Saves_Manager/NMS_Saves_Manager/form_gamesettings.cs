using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.XPath;

namespace NMS_Saves_Manager
{
    public partial class form_gamesettings : Form
    {
        static string NMSpath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        static string lastloadedstorage = NMSpath + @"\profilstorage";
        static string graphicset = NMSpath + @"\SETTINGS\TKGRAPHICSSETTINGS.MXML";
        static string gameset = NMSpath + @"\SETTINGS\TKGAMESETTINGS.MXML";
        static string userset = NMSpath + @"\SETTINGS\GCUSERSETTINGSDATA.MXML";
        private string widthvalue = "";
        private string heightvalue = "";


        public form_gamesettings()
        {
            InitializeComponent();

            var doc = new XmlDocument();
            doc.Load(graphicset);
            foreach (XmlNode node in doc.SelectNodes("Data/Property[@name]"))
            {
                string name = (node.Attributes[@"name"].Value);

                switch (name)
                {
                    case "FullScreen":
                        bool FullscreenLast = Convert.ToBoolean(node.Attributes[@"value"].Value);
                        chk_Fullscreen.Checked = FullscreenLast;
                        break;

                    case "Borderless":
                        bool Borderless = Convert.ToBoolean(node.Attributes[@"value"].Value);
                        chk_borderless.Checked = Borderless;
                        break;

                    case "GSync":
                        bool GSync = Convert.ToBoolean(node.Attributes[@"value"].Value);
                        chk_gsync.Checked = GSync;
                        break;

                    case "VSync":
                        bool VSync = Convert.ToBoolean(node.Attributes[@"value"].Value);
                        chk_vsync.Checked = VSync;
                        break;

                    case "UseScreenResolution":
                        bool UseScreenResolution = Convert.ToBoolean(node.Attributes[@"value"].Value);
                        chk_screenres.Checked = UseScreenResolution;
                        break;

                    case "NoHudMode":
                        bool NoHudMode = Convert.ToBoolean(node.Attributes[@"value"].Value);
                        chk_hud.Checked = NoHudMode;
                        break;

                    case "ResolutionWidth":
                        string ResolutionWidth = (node.Attributes[@"value"].Value);
                        //var resowidth = int.Parse(ResolutionWidth.Split('.')[0]);
                        //trb_reswidth.Value = resowidth;
                        tb_reswidth.Text = ResolutionWidth.ToString();
                        break;

                    case "ResolutionHeight":
                        string ResolutionHeight = (node.Attributes[@"value"].Value);
                        //var resoheight = int.Parse(ResolutionHeight.Split('.')[0]);
                        //trb_reswidth.Value = resoheight;
                        tb_resheight.Text = ResolutionHeight.ToString();
                        break;

                    case "FoVOnFoot":
                        string FoVOnFoot = (node.Attributes[@"value"].Value);
                        var fovfoot = int.Parse(FoVOnFoot.Split('.')[0]);
                        trb_fovfoot.Value = fovfoot;
                        tb_fovfoot.Text = FoVOnFoot.ToString();
                        break;

                    case "FoVInShip":
                        string FoVInShip = (node.Attributes[@"value"].Value);
                        var fovship = int.Parse(FoVInShip.Split('.')[0]);
                        trb_fovship.Value = fovship;
                        tb_fovship.Text = FoVInShip.ToString();
                        break;

                    case "Brightness":
                        string Brightness = (node.Attributes[@"value"].Value);
                        trb_brightness.Value = Convert.ToInt32(Brightness);
                        tb_brightness.Text = Brightness;
                        break;

                    case "GenerationDetail":
                        string GenerationDetail = (node.Attributes[@"value"].Value);
                        cb_generation.Items.Add("Low");
                        cb_generation.Items.Add("Normal");
                        cb_generation.Items.Add("High");

                        switch (GenerationDetail)
                        {
                            case "Low":
                                cb_generation.SelectedIndex = 0;
                                break;

                            case "Normal":
                                cb_generation.SelectedIndex = 1;
                                break;

                            case "High":
                                cb_generation.SelectedIndex = 2;
                                break;
                        }
                        break;

                    case "ReflectionsQuality":
                        string ReflectionsQuality = (node.Attributes[@"value"].Value);
                        cb_reflections.Items.Add("Low");
                        cb_reflections.Items.Add("Normal");
                        cb_reflections.Items.Add("High");

                        switch (ReflectionsQuality)
                        {
                            case "Low":
                              cb_reflections.SelectedIndex = 0;
                                break;

                            case "Normal":
                              cb_reflections.SelectedIndex = 1;
                                break;

                            case "High":
                              cb_reflections.SelectedIndex = 2;
                                break;
                         }
                        break;

                    case "ShadowDetail":
                        string ShadowDetail = (node.Attributes[@"value"].Value);
                        cb_shadows.Items.Add("Low");
                        cb_shadows.Items.Add("Normal");
                        cb_shadows.Items.Add("High");

                        switch (ShadowDetail)
                        {
                            case "Low":
                                cb_shadows.SelectedIndex = 0;
                                break;

                            case "Normal":
                                cb_shadows.SelectedIndex = 1;
                                break;

                            case "High":
                                cb_shadows.SelectedIndex = 2;
                                break;
                        }
                        break;

                    case "TextureDetail":
                        string TextureDetail = (node.Attributes[@"value"].Value);
                        cb_textures.Items.Add("Low");
                        cb_textures.Items.Add("Normal");
                        cb_textures.Items.Add("High");

                        switch (TextureDetail)
                        {
                            case "Low":
                                cb_textures.SelectedIndex = 0;
                                break;

                            case "Normal":
                                cb_textures.SelectedIndex = 1;
                                break;

                            case "High":
                                cb_textures.SelectedIndex = 2;
                                break;
                        }
                        break;

                    case "MaxframeRate":
                        string MaxframeRate = (node.Attributes[@"value"].Value);
                        cb_framerate.Items.Add("30");
                        cb_framerate.Items.Add("60");
                        cb_framerate.Items.Add("90");
                        cb_framerate.Items.Add("110");
                        cb_framerate.Items.Add("160");

                        switch (MaxframeRate)
                        {
                            case "30":
                                cb_framerate.SelectedIndex = 0;
                                break;

                            case "60":
                                cb_framerate.SelectedIndex = 1;
                                break;

                            case "90":
                                cb_framerate.SelectedIndex = 2;
                                break;

                            case "110":
                                cb_framerate.SelectedIndex = 3;
                                break;

                            case "160":
                                cb_framerate.SelectedIndex = 4;
                                break;
                        }
                        break;

                    case "AnisotropyLevel":
                        string AnisotropyLevel = (node.Attributes[@"value"].Value);
                        cb_aniso.Items.Add("1");
                        cb_aniso.Items.Add("2");
                        cb_aniso.Items.Add("4");
                        cb_aniso.Items.Add("8");
                        cb_aniso.Items.Add("16");                     

                        switch (AnisotropyLevel)
                        {
                            case "1":
                                cb_aniso.SelectedIndex = 0;
                                break;

                            case "2":
                                cb_aniso.SelectedIndex = 1;
                                break;

                            case "4":
                                cb_aniso.SelectedIndex = 2;
                                break;

                            case "8":
                                cb_aniso.SelectedIndex = 3;
                                break;

                            case "16":
                                cb_aniso.SelectedIndex = 4;
                                break;
                        }
                        break;

                    case "Monitor":
                        string Monitor = (node.Attributes[@"value"].Value);
                        cb_monitor.Items.Add("0");
                        cb_monitor.Items.Add("1");

                        switch (Monitor)
                        {
                            case "0":
                                cb_monitor.SelectedIndex = 0;
                                break;

                            case "1":
                                cb_monitor.SelectedIndex = 1;
                                break;
                        }
                        break;

                    case "AntiAliasing":
                        string AntiAliasing = (node.Attributes[@"value"].Value);
                        cb_aa.Items.Add("FXAA");
                        cb_aa.Items.Add("SSAA4");
                        cb_aa.Items.Add("None");

                        switch (AntiAliasing)
                        {
                            case "FXAA":
                                cb_aa.SelectedIndex = 0;
                                break;

                            case "SSAA4":
                                cb_aa.SelectedIndex = 1;
                                break;

                            case "None":
                                cb_aa.SelectedIndex = 1;
                                break;
                        }
                        break;
                }


            }

            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            lbl_screeninfo.Text = "Actual screen resolution: " + resolution ; 

        }

        private void trb_fovfoot_Scroll(object sender, EventArgs e)
        {
            tb_fovfoot.Text = (trb_fovfoot.Value.ToString() + ".000000");
        }

        private void trb_fovship_Scroll(object sender, EventArgs e)
        {
            tb_fovship.Text = (trb_fovship.Value.ToString() + ".000000");
        }

        private void trb_brightness_Scroll(object sender, EventArgs e)
        {
            tb_brightness.Text = trb_brightness.Value.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var save = new XmlDocument();
            save.Load(graphicset);
            foreach (XmlNode node in save.SelectNodes("Data/Property[@name]"))
            {
                string name = (node.Attributes[@"name"].Value);

                switch (name)
                {
                    case "Fullscreen":
                        node.Attributes[@"value"].Value = chk_Fullscreen.Checked.ToString();
                        break;

                    case "Borderless":
                        node.Attributes[@"value"].Value = chk_borderless.Checked.ToString();
                        break;

                    case "VSync":
                        node.Attributes[@"value"].Value = chk_vsync.Checked.ToString();
                        break;

                    case "GSync":
                        node.Attributes[@"value"].Value = chk_gsync.Checked.ToString();
                        break;

                    case "UseScreenResolution":
                        node.Attributes[@"value"].Value = chk_screenres.Checked.ToString();
                        break;

                    case "NoHudMode":
                        node.Attributes[@"value"].Value = chk_hud.Checked.ToString();
                        break;

                    case "Monitor":
                        node.Attributes[@"value"].Value = cb_monitor.SelectedItem.ToString();
                        break;

                    case "ShadowDetail":
                        node.Attributes[@"value"].Value = cb_shadows.SelectedItem.ToString();
                        break;

                    case "TextureDetail":
                        node.Attributes[@"value"].Value = cb_textures.SelectedItem.ToString();
                        break;

                    case "AntiAliasing":
                        node.Attributes[@"value"].Value = cb_aa.SelectedItem.ToString();
                        break;

                    case "MaxframeRate":
                        node.Attributes[@"value"].Value = cb_framerate.SelectedItem.ToString();
                        break;

                    case "GenerationDetail":
                        node.Attributes[@"value"].Value = cb_generation.SelectedItem.ToString();
                        break;

                    case "ReflectionsQuality":
                        node.Attributes[@"value"].Value = cb_reflections.SelectedItem.ToString();
                        break;

                    case "AnisotropyLevel":
                        node.Attributes[@"value"].Value = cb_aniso.SelectedItem.ToString();
                        break;

                    case "FoVOnFoot":
                        node.Attributes[@"value"].Value = trb_fovfoot.Value.ToString();
                        break;

                    case "FoVInShip":
                        node.Attributes[@"value"].Value = trb_fovship.Value.ToString();
                        break;

                    case "Brightness":
                        node.Attributes[@"value"].Value = trb_brightness.Value.ToString();
                        break;

                    case "ResolutionWidth":
                        node.Attributes[@"value"].Value = trb_reswidth.Value.ToString();
                        break;

                    case "ResolutionHeight":
                        node.Attributes[@"value"].Value = trb_resheight.Value.ToString();
                        break;

                }
                save.Save(graphicset);
                this.Close();
            }
        }

        private void tb_reswidth_TextChanged_1(object sender, EventArgs e)
        {
            var oGValue = double.Parse(tb_reswidth.Text);
            trb_reswidth.Value = int.Parse(oGValue.ToString());
        }

        private void tb_resheight_TextChanged_1(object sender, EventArgs e)
        {
            var oGValue2 = double.Parse(tb_resheight.Text);
            trb_resheight.Value = int.Parse(oGValue2.ToString());
        }
    }
}
