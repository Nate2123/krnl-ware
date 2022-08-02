using sxlib;
using sxlib.Specialized;
using System;
using System.Windows.Forms;
using System.IO;
namespace krnl_ware
{

    public partial class Form1 : Form
    {

        public SxLibWinForms SLib;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SLib = SxLib.InitializeWinForms(this, Directory.GetCurrentDirectory());
            SLib.LoadEvent += LibraryLoadEvent;
            SLib.AttachEvent += LibraryAttachEvent;
            SLib.Load();
        }
        private void LibraryAttachEvent(SxLibBase.SynAttachEvents Event, object whatever)
        {
            switch (Event)
            {

                case SxLibBase.SynAttachEvents.ALREADY_INJECTED:
                    richTextBox2.Text = "skid its already injected LOLZ!";
                    break;
                case SxLibBase.SynAttachEvents.CHECKING:
                    richTextBox2.Text = "im checking shit u nerd";
                    break;
                case SxLibBase.SynAttachEvents.CHECKING_WHITELIST:
                    richTextBox2.Text = "im checking if ur not retarded and got blacklisted";
                    break;
                case SxLibBase.SynAttachEvents.FAILED_TO_ATTACH:
                    richTextBox2.Text = "omg u skid u failed to attach imagine";
                    break;
                case SxLibBase.SynAttachEvents.FAILED_TO_FIND:
                    richTextBox2.Text = "skid run roblox first";
                    break;
                case SxLibBase.SynAttachEvents.FAILED_TO_UPDATE:
                    richTextBox2.Text = "bru hwhat the fuk it failed to update skid";
                    break;
                case SxLibBase.SynAttachEvents.INJECTING:
                    richTextBox2.Text = "stick that needle up your ass and inject the krnl-ware code";
                    break;
                case SxLibBase.SynAttachEvents.NOT_INJECTED:
                    richTextBox2.Text = "its not injected skid!;";
                    break;
                case SxLibBase.SynAttachEvents.NOT_RUNNING_LATEST_VER_UPDATING:
                    richTextBox2.Text = "imagine not having the latest ver owo";
                    break;
                case SxLibBase.SynAttachEvents.NOT_UPDATED:
                    richTextBox2.Text = "not updated u nerd";
                    break;
                case SxLibBase.SynAttachEvents.PROC_CREATION:
                    richTextBox2.Text = "nerd lol";
                    break;
                case SxLibBase.SynAttachEvents.PROC_DELETION:
                    richTextBox2.Text = "bye bye roblox";
                    break;
                case SxLibBase.SynAttachEvents.READY:
                    richTextBox2.Text = "its fucking ready u skid";
                    break;
                case SxLibBase.SynAttachEvents.REINJECTING:
                    richTextBox2.Text = "reijecting nerd";
                    break;
                case SxLibBase.SynAttachEvents.SCANNING:
                    richTextBox2.Text = "es scan ning";
                    break;
                case SxLibBase.SynAttachEvents.UPDATING_DLLS:
                    richTextBox2.Text = "idk why u ran this as it was updating the dlls but okay<3";
                    break;

            }
        }
        private void LibraryLoadEvent(SxLibBase.SynLoadEvents Event, object whatever)
        {
            switch (Event)
            {
                case SxLibBase.SynLoadEvents.CHECKING_WL:
                    richTextBox2.Text = "checing witelist";
                    break;
                case SxLibBase.SynLoadEvents.CHANGING_WL:
                    richTextBox2.Text = "ong changing witelis";
                    break;
                case SxLibBase.SynLoadEvents.DOWNLOADING_DATA:
                    richTextBox2.Text = "DOWNloading DATa!";

                    break;
                case SxLibBase.SynLoadEvents.CHECKING_DATA:
                    richTextBox2.Text = "ONG IM CHECKING DA DATA!";
                    break;
                case SxLibBase.SynLoadEvents.DOWNLOADING_DLLS:
                    richTextBox2.Text = "OMG ALMOST THERE!";

                    break;
                case SxLibBase.SynLoadEvents.READY:
                    richTextBox2.Text = "its ready u fucking skid";
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SLib.Attach();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SLib.Execute(richTextBox1.Text);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
 
        }

        
    }
}
