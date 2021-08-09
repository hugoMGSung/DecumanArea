
namespace DecumanMRP
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.kryptonRibbon1 = new Krypton.Ribbon.KryptonRibbon();
            this.kryptonDockableWorkspace1 = new Krypton.Docking.KryptonDockableWorkspace();
            this.KdmMain = new Krypton.Docking.KryptonDockingManager();
            this.ImgListSmall = new System.Windows.Forms.ImageList(this.components);
            this.KmnMain = new Krypton.Toolkit.KryptonManager(this.components);
            this.OfdMain = new System.Windows.Forms.OpenFileDialog();
            this.SfdMain = new System.Windows.Forms.SaveFileDialog();
            this.KrpMain = new Krypton.Toolkit.KryptonPanel();
            this.KdwMain = new Krypton.Docking.KryptonDockableWorkspace();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KrpMain)).BeginInit();
            this.KrpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KdwMain)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.SelectedContext = null;
            this.kryptonRibbon1.SelectedTab = null;
            this.kryptonRibbon1.Size = new System.Drawing.Size(1062, 134);
            this.kryptonRibbon1.TabIndex = 0;
            // 
            // kryptonDockableWorkspace1
            // 
            this.kryptonDockableWorkspace1.ActivePage = null;
            this.kryptonDockableWorkspace1.AutoHiddenHost = false;
            this.kryptonDockableWorkspace1.CompactFlags = ((Krypton.Workspace.CompactFlags)(((Krypton.Workspace.CompactFlags.RemoveEmptyCells | Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.kryptonDockableWorkspace1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDockableWorkspace1.Name = "kryptonDockableWorkspace1";
            // 
            // 
            // 
            this.kryptonDockableWorkspace1.Root.UniqueName = "2ac85be97cd04fadbb73f3042ebb28ce";
            this.kryptonDockableWorkspace1.Root.WorkspaceControl = this.kryptonDockableWorkspace1;
            this.kryptonDockableWorkspace1.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace1.Size = new System.Drawing.Size(200, 200);
            this.kryptonDockableWorkspace1.TabIndex = 0;
            this.kryptonDockableWorkspace1.TabStop = true;
            // 
            // ImgListSmall
            // 
            this.ImgListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgListSmall.ImageStream")));
            this.ImgListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgListSmall.Images.SetKeyName(0, "new.png");
            this.ImgListSmall.Images.SetKeyName(1, "system.png");
            this.ImgListSmall.Images.SetKeyName(2, "information.png");
            this.ImgListSmall.Images.SetKeyName(3, "");
            this.ImgListSmall.Images.SetKeyName(4, "input.png");
            // 
            // KmnMain
            // 
            this.KmnMain.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office365Black;
            // 
            // OfdMain
            // 
            this.OfdMain.FileName = "FileName";
            // 
            // KrpMain
            // 
            this.KrpMain.Controls.Add(this.KdwMain);
            this.KrpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KrpMain.Location = new System.Drawing.Point(0, 134);
            this.KrpMain.Name = "KrpMain";
            this.KrpMain.Size = new System.Drawing.Size(1062, 489);
            this.KrpMain.TabIndex = 2;
            // 
            // KdwMain
            // 
            this.KdwMain.ActivePage = null;
            this.KdwMain.AutoHiddenHost = false;
            this.KdwMain.CompactFlags = ((Krypton.Workspace.CompactFlags)(((Krypton.Workspace.CompactFlags.RemoveEmptyCells | Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.KdwMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KdwMain.Location = new System.Drawing.Point(0, 0);
            this.KdwMain.Name = "KdwMain";
            // 
            // 
            // 
            this.KdwMain.Root.UniqueName = "a25fadbf2c5d492dbc49b959b20fe617";
            this.KdwMain.Root.WorkspaceControl = this.KdwMain;
            this.KdwMain.ShowMaximizeButton = false;
            this.KdwMain.Size = new System.Drawing.Size(1062, 489);
            this.KdwMain.TabIndex = 2;
            this.KdwMain.TabStop = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 623);
            this.Controls.Add(this.KrpMain);
            this.Controls.Add(this.kryptonRibbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decuman MRP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KrpMain)).EndInit();
            this.KrpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KdwMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private Krypton.Docking.KryptonDockingManager KdmMain;
        private System.Windows.Forms.ImageList ImgListSmall;
        private Krypton.Toolkit.KryptonManager KmnMain;
        private System.Windows.Forms.OpenFileDialog OfdMain;
        private System.Windows.Forms.SaveFileDialog SfdMain;
        private Krypton.Toolkit.KryptonPanel KrpMain;
        private Krypton.Docking.KryptonDockableWorkspace KdwMain;
    }
}

