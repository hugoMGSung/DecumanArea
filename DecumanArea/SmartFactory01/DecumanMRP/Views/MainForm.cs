using DecumanMRP.StaticInfo;
using DecumanMRP.UserControls;
using DecumanMRP.Views;
using Krypton.Docking;
using Krypton.Navigator;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecumanMRP
{
    public partial class MainForm : KryptonForm //Form
    {
        private int _count = 1;

        public MainForm()
        {
            InitializeComponent();

            #region SplashScreen 시작

            int sleepTime = 2000;
            Thread splashThread = new Thread(LoadingScreen.ShowSplashScreen);
            splashThread.IsBackground = true;
            splashThread.Start();

            #endregion SplashScreen 끝

            #region Loading 1

            Thread.Sleep(sleepTime);
            LoadingScreen.UdpateStatusText("Loading 1..");

            try
            {
                Thread.Sleep(sleepTime);
                LoadingScreen.UdpateStatusTextWithStatus("Loading 1 OK", TypeOfMessage.Success);
                Thread.Sleep(sleepTime);
            }
            catch (System.Exception ex)
            {
                LoadingScreen.UdpateStatusTextWithStatus("Loading 1 Fail", TypeOfMessage.Error);
                Environment.Exit(0);
            }

            #endregion


            #region Loading 2

            LoadingScreen.UdpateStatusText("Loading 2..");

            try
            {
                Thread.Sleep(sleepTime);
                LoadingScreen.UdpateStatusTextWithStatus("Loading 2 OK", TypeOfMessage.Success);
                Thread.Sleep(sleepTime);
            }
            catch (System.Exception ex)
            {
                LoadingScreen.UdpateStatusTextWithStatus("Loading 2 Fail", TypeOfMessage.Error);
                Environment.Exit(0);
            }

            #endregion


            LoadingScreen.CloseSplashScreen();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 도킹기능 셋팅
            KryptonDockingWorkspace workspace = KdmMain.ManageWorkspace(KdwMain);
            KdmMain.ManageControl(KrpMain, workspace);
            KdmMain.ManageFloating(this);

            // 도킹페이지 추가
            KdmMain.AddDockspace("Control", DockingEdge.Left, new KryptonPage[] { NewProjectView() });
            KdmMain.AddAutoHiddenGroup("Control", DockingEdge.Right, new KryptonPage[] { NewPropertyView() });
            KdmMain.AddDockspace("Control", DockingEdge.Bottom, new KryptonPage[] { NewInputView(), NewInputView() });
            KdmMain.AddToWorkspace("Workspace", new KryptonPage[] { NewDocumentView(), NewDocumentView(), NewDocumentView() });
        }

        private KryptonPage NewProjectView()
        {
            return NewPage("Project View", 3, new CntProjectView());
        }

        private KryptonPage NewPropertyView()
        {
            return NewPage("Property View", 1, new CntPropertyView());
        }

        private KryptonPage NewInputView()
        {
            return NewPage("Input View", 4, new CntInputView());
        }

        private KryptonPage NewDocumentView()
        {
            return NewPage("Document View", 0, new CntDocumentView());
        }

        private KryptonPage NewPage(string name, int image, Control content)
        {
            // Create new page with title and image
            KryptonPage p = new KryptonPage
            {
                Text = name + _count.ToString(),
                TextTitle = name + _count.ToString(),
                TextDescription = name + _count.ToString()
            };
            p.UniqueName = p.Text;
            p.ImageSmall = ImgListSmall.Images[image];

            // Add the control for display inside the page
            content.Dock = DockStyle.Fill;
            p.Controls.Add(content);

            _count++;
            return p;
        }
    }
}
