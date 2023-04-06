namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.shapesLabel = new System.Windows.Forms.ToolStripLabel();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawEllipseSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawSquareSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawLineSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawCircleButton = new System.Windows.Forms.ToolStripButton();
            this.drawPointButton = new System.Windows.Forms.ToolStripButton();
            this.addRndTrapeze = new System.Windows.Forms.ToolStripButton();
            this.functionsLabel = new System.Windows.Forms.ToolStripLabel();
            this.RotateButton = new System.Windows.Forms.ToolStripButton();
            this.Rotate180Btn = new System.Windows.Forms.ToolStripButton();
            this.GroupShapeBtn = new System.Windows.Forms.ToolStripButton();
            this.UngroupShapeBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteShapesBtn = new System.Windows.Forms.ToolStripButton();
            this.SelectAllBtn = new System.Windows.Forms.ToolStripButton();
            this.UnselectAllBtn = new System.Windows.Forms.ToolStripButton();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.strokeColorDialog = new System.Windows.Forms.ColorDialog();
            this.colorStrip = new System.Windows.Forms.ToolStrip();
            this.fillColorLabel = new System.Windows.Forms.ToolStripLabel();
            this.fillColorSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.selectedColorTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.borderColorLabel = new System.Windows.Forms.ToolStripLabel();
            this.colorDialogSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.strokeColorTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.opacityLabel = new System.Windows.Forms.ToolStripLabel();
            this.opacityComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ResizeBtn = new System.Windows.Forms.ToolStripButton();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.WidthTB = new System.Windows.Forms.TextBox();
            this.HeightTB = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.colorStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(917, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 480);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(3, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(917, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // speedMenu
            // 
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpSpeedButton,
            this.shapesLabel,
            this.drawRectangleSpeedButton,
            this.drawEllipseSpeedButton,
            this.drawSquareSpeedButton,
            this.drawLineSpeedButton,
            this.drawCircleButton,
            this.drawPointButton,
            this.addRndTrapeze,
            this.toolStripButton1,
            this.functionsLabel,
            this.RotateButton,
            this.Rotate180Btn,
            this.GroupShapeBtn,
            this.UngroupShapeBtn,
            this.DeleteShapesBtn,
            this.SelectAllBtn,
            this.UnselectAllBtn});
            this.speedMenu.Location = new System.Drawing.Point(0, 28);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.speedMenu.Size = new System.Drawing.Size(917, 31);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "drawCircle";
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            // 
            // shapesLabel
            // 
            this.shapesLabel.Name = "shapesLabel";
            this.shapesLabel.Size = new System.Drawing.Size(59, 28);
            this.shapesLabel.Text = "Shapes:";
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // drawEllipseSpeedButton
            // 
            this.drawEllipseSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawEllipseSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawEllipseSpeedButton.Image")));
            this.drawEllipseSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawEllipseSpeedButton.Name = "drawEllipseSpeedButton";
            this.drawEllipseSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.drawEllipseSpeedButton.Text = "DrawEllipseButton";
            this.drawEllipseSpeedButton.Click += new System.EventHandler(this.DrawEllipseSpeedButtonClick);
            // 
            // drawSquareSpeedButton
            // 
            this.drawSquareSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawSquareSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawSquareSpeedButton.Image")));
            this.drawSquareSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawSquareSpeedButton.Name = "drawSquareSpeedButton";
            this.drawSquareSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.drawSquareSpeedButton.Text = "DrawSquareButton";
            this.drawSquareSpeedButton.Click += new System.EventHandler(this.DrawSquareSpeedButtonClick);
            // 
            // drawLineSpeedButton
            // 
            this.drawLineSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawLineSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawLineSpeedButton.Image")));
            this.drawLineSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawLineSpeedButton.Name = "drawLineSpeedButton";
            this.drawLineSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.drawLineSpeedButton.Text = "DrawLineButton";
            this.drawLineSpeedButton.Click += new System.EventHandler(this.DrawLineSpeedButtonClick);
            // 
            // drawCircleButton
            // 
            this.drawCircleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawCircleButton.Image = ((System.Drawing.Image)(resources.GetObject("drawCircleButton.Image")));
            this.drawCircleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawCircleButton.Name = "drawCircleButton";
            this.drawCircleButton.Size = new System.Drawing.Size(29, 28);
            this.drawCircleButton.Text = "drawCircleButton";
            this.drawCircleButton.Click += new System.EventHandler(this.drawCircleButton_Click);
            // 
            // drawPointButton
            // 
            this.drawPointButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawPointButton.Image = ((System.Drawing.Image)(resources.GetObject("drawPointButton.Image")));
            this.drawPointButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawPointButton.Name = "drawPointButton";
            this.drawPointButton.Size = new System.Drawing.Size(29, 28);
            this.drawPointButton.Text = "DrawPointButton";
            this.drawPointButton.Click += new System.EventHandler(this.drawPointButton_Click);
            // 
            // addRndTrapeze
            // 
            this.addRndTrapeze.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addRndTrapeze.Image = ((System.Drawing.Image)(resources.GetObject("addRndTrapeze.Image")));
            this.addRndTrapeze.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addRndTrapeze.Name = "addRndTrapeze";
            this.addRndTrapeze.Size = new System.Drawing.Size(29, 28);
            this.addRndTrapeze.Text = "addRndTrapeze";
            this.addRndTrapeze.Click += new System.EventHandler(this.addRndTrapeze_Click);
            // 
            // functionsLabel
            // 
            this.functionsLabel.Name = "functionsLabel";
            this.functionsLabel.Size = new System.Drawing.Size(74, 28);
            this.functionsLabel.Text = "Functions:";
            // 
            // RotateButton
            // 
            this.RotateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RotateButton.Image = ((System.Drawing.Image)(resources.GetObject("RotateButton.Image")));
            this.RotateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(29, 28);
            this.RotateButton.Text = "RotateButton";
            this.RotateButton.Click += new System.EventHandler(this.RotateButtonClick);
            // 
            // Rotate180Btn
            // 
            this.Rotate180Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rotate180Btn.Image = ((System.Drawing.Image)(resources.GetObject("Rotate180Btn.Image")));
            this.Rotate180Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rotate180Btn.Name = "Rotate180Btn";
            this.Rotate180Btn.Size = new System.Drawing.Size(29, 28);
            this.Rotate180Btn.Text = "Rotate180Btn";
            this.Rotate180Btn.Click += new System.EventHandler(this.Rotate180Btn_Click);
            // 
            // GroupShapeBtn
            // 
            this.GroupShapeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GroupShapeBtn.Image = ((System.Drawing.Image)(resources.GetObject("GroupShapeBtn.Image")));
            this.GroupShapeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GroupShapeBtn.Name = "GroupShapeBtn";
            this.GroupShapeBtn.Size = new System.Drawing.Size(29, 28);
            this.GroupShapeBtn.Text = "GroupShapeBtn";
            this.GroupShapeBtn.Click += new System.EventHandler(this.GroupShapeBtn_Click);
            // 
            // UngroupShapeBtn
            // 
            this.UngroupShapeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UngroupShapeBtn.Image = ((System.Drawing.Image)(resources.GetObject("UngroupShapeBtn.Image")));
            this.UngroupShapeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UngroupShapeBtn.Name = "UngroupShapeBtn";
            this.UngroupShapeBtn.Size = new System.Drawing.Size(29, 28);
            this.UngroupShapeBtn.Text = "UngroupShapeBtn";
            this.UngroupShapeBtn.Click += new System.EventHandler(this.UngroupShapeBtn_Click);
            // 
            // DeleteShapesBtn
            // 
            this.DeleteShapesBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteShapesBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteShapesBtn.Image")));
            this.DeleteShapesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteShapesBtn.Name = "DeleteShapesBtn";
            this.DeleteShapesBtn.Size = new System.Drawing.Size(29, 28);
            this.DeleteShapesBtn.Text = "DeleteShapesBtn";
            this.DeleteShapesBtn.Click += new System.EventHandler(this.DeleteShapesBtn_Click);
            // 
            // SelectAllBtn
            // 
            this.SelectAllBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SelectAllBtn.Image = ((System.Drawing.Image)(resources.GetObject("SelectAllBtn.Image")));
            this.SelectAllBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectAllBtn.Name = "SelectAllBtn";
            this.SelectAllBtn.Size = new System.Drawing.Size(29, 28);
            this.SelectAllBtn.Text = "SelectAllBtn";
            this.SelectAllBtn.Click += new System.EventHandler(this.SelectAllBtn_Click);
            // 
            // UnselectAllBtn
            // 
            this.UnselectAllBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnselectAllBtn.Image = ((System.Drawing.Image)(resources.GetObject("UnselectAllBtn.Image")));
            this.UnselectAllBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnselectAllBtn.Name = "UnselectAllBtn";
            this.UnselectAllBtn.Size = new System.Drawing.Size(29, 28);
            this.UnselectAllBtn.Text = "UnselectAllBtn";
            this.UnselectAllBtn.Click += new System.EventHandler(this.UnselectAllBtn_Click);
            // 
            // colorStrip
            // 
            this.colorStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.colorStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillColorLabel,
            this.fillColorSpeedButton,
            this.selectedColorTextBox,
            this.borderColorLabel,
            this.colorDialogSpeedButton,
            this.strokeColorTextBox,
            this.opacityLabel,
            this.opacityComboBox,
            this.ResizeBtn});
            this.colorStrip.Location = new System.Drawing.Point(0, 59);
            this.colorStrip.Name = "colorStrip";
            this.colorStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.colorStrip.Size = new System.Drawing.Size(917, 31);
            this.colorStrip.TabIndex = 5;
            this.colorStrip.Text = "toolStrip1";
            // 
            // fillColorLabel
            // 
            this.fillColorLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fillColorLabel.Name = "fillColorLabel";
            this.fillColorLabel.Size = new System.Drawing.Size(34, 28);
            this.fillColorLabel.Text = "Fill:";
            // 
            // fillColorSpeedButton
            // 
            this.fillColorSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillColorSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("fillColorSpeedButton.Image")));
            this.fillColorSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillColorSpeedButton.Name = "fillColorSpeedButton";
            this.fillColorSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.fillColorSpeedButton.Text = "ColorDialogSpeedButton";
            this.fillColorSpeedButton.Click += new System.EventHandler(this.fillColorSpeedButton_Click);
            // 
            // selectedColorTextBox
            // 
            this.selectedColorTextBox.BackColor = System.Drawing.Color.Black;
            this.selectedColorTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectedColorTextBox.Name = "selectedColorTextBox";
            this.selectedColorTextBox.ReadOnly = true;
            this.selectedColorTextBox.Size = new System.Drawing.Size(29, 31);
            // 
            // borderColorLabel
            // 
            this.borderColorLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.borderColorLabel.Name = "borderColorLabel";
            this.borderColorLabel.Size = new System.Drawing.Size(65, 28);
            this.borderColorLabel.Text = "Border:";
            // 
            // colorDialogSpeedButton
            // 
            this.colorDialogSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorDialogSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("colorDialogSpeedButton.Image")));
            this.colorDialogSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorDialogSpeedButton.Name = "colorDialogSpeedButton";
            this.colorDialogSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.colorDialogSpeedButton.Text = "ColorDialogSpeedButton";
            this.colorDialogSpeedButton.Click += new System.EventHandler(this.colorDialogSpeedButton_Click);
            // 
            // strokeColorTextBox
            // 
            this.strokeColorTextBox.BackColor = System.Drawing.Color.Red;
            this.strokeColorTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.strokeColorTextBox.Name = "strokeColorTextBox";
            this.strokeColorTextBox.ReadOnly = true;
            this.strokeColorTextBox.Size = new System.Drawing.Size(29, 31);
            // 
            // opacityLabel
            // 
            this.opacityLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(72, 28);
            this.opacityLabel.Text = "Opacity:";
            // 
            // opacityComboBox
            // 
            this.opacityComboBox.Items.AddRange(new object[] {
            "0%",
            "25%",
            "50%",
            "75%",
            "100%"});
            this.opacityComboBox.Name = "opacityComboBox";
            this.opacityComboBox.Size = new System.Drawing.Size(98, 31);
            this.opacityComboBox.Text = "100%";
            this.opacityComboBox.ToolTipText = "Opacity";
            this.opacityComboBox.SelectedIndexChanged += new System.EventHandler(this.opacityComboBox_SelectedIndexChanged);
            // 
            // ResizeBtn
            // 
            this.ResizeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ResizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("ResizeBtn.Image")));
            this.ResizeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResizeBtn.Name = "ResizeBtn";
            this.ResizeBtn.Size = new System.Drawing.Size(29, 28);
            this.ResizeBtn.Text = "ResizeBtn";
            this.ResizeBtn.Click += new System.EventHandler(this.ResizeBtn_Click);
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 59);
            this.viewPort.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(917, 421);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // WidthTB
            // 
            this.WidthTB.Location = new System.Drawing.Point(552, 78);
            this.WidthTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WidthTB.Name = "WidthTB";
            this.WidthTB.Size = new System.Drawing.Size(57, 22);
            this.WidthTB.TabIndex = 6;
            // 
            // HeightTB
            // 
            this.HeightTB.Location = new System.Drawing.Point(677, 78);
            this.HeightTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeightTB.Name = "HeightTB";
            this.HeightTB.Size = new System.Drawing.Size(57, 22);
            this.HeightTB.TabIndex = 7;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(496, 82);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(44, 16);
            this.WidthLabel.TabIndex = 8;
            this.WidthLabel.Text = "Width:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(617, 82);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(49, 16);
            this.HeightLabel.TabIndex = 9;
            this.HeightLabel.Text = "Height:";
            // 
            // saveDialog
            // 
            this.saveDialog.FileName = "saveDialog";
            // 
            // loadDialog
            // 
            this.loadDialog.FileName = "loadDialog";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 502);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightTB);
            this.Controls.Add(this.WidthTB);
            this.Controls.Add(this.colorStrip);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.colorStrip.ResumeLayout(false);
            this.colorStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripButton drawEllipseSpeedButton;
		private System.Windows.Forms.ToolStripButton drawSquareSpeedButton;
		private System.Windows.Forms.ToolStripButton drawLineSpeedButton;
		private System.Windows.Forms.ToolStripButton RotateButton;
        private System.Windows.Forms.ToolStripButton drawCircleButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ColorDialog strokeColorDialog;
        private System.Windows.Forms.ToolStrip colorStrip;
        private System.Windows.Forms.ToolStripButton fillColorSpeedButton;
        protected System.Windows.Forms.ToolStripTextBox selectedColorTextBox;
        private System.Windows.Forms.ToolStripButton colorDialogSpeedButton;
        protected System.Windows.Forms.ToolStripTextBox strokeColorTextBox;
        private System.Windows.Forms.ToolStripButton drawPointButton;
        private System.Windows.Forms.ToolStripLabel fillColorLabel;
        private System.Windows.Forms.ToolStripLabel borderColorLabel;
        private System.Windows.Forms.ToolStripLabel opacityLabel;
        private System.Windows.Forms.ToolStripComboBox opacityComboBox;
        private System.Windows.Forms.ToolStripLabel shapesLabel;
        private System.Windows.Forms.ToolStripLabel functionsLabel;
        private System.Windows.Forms.ToolStripButton addRndTrapeze;
        private System.Windows.Forms.ToolStripButton GroupShapeBtn;
        private System.Windows.Forms.ToolStripButton UngroupShapeBtn;
        private System.Windows.Forms.ToolStripButton DeleteShapesBtn;
        private System.Windows.Forms.TextBox WidthTB;
        private System.Windows.Forms.TextBox HeightTB;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.ToolStripButton SelectAllBtn;
        private System.Windows.Forms.ToolStripButton UnselectAllBtn;
        private System.Windows.Forms.ToolStripButton Rotate180Btn;
        private System.Windows.Forms.ToolStripButton ResizeBtn;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog loadDialog;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
