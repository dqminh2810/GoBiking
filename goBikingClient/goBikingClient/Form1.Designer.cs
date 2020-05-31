namespace goBikingClient
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.contractListBox = new System.Windows.Forms.ListBox();
            this.stationListBox = new System.Windows.Forms.ListBox();
            this.validButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.availableLabel = new System.Windows.Forms.Label();
            this.stationListBox2 = new System.Windows.Forms.ListBox();
            this.contractListBox2 = new System.Windows.Forms.ListBox();
            this.availableLabel2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lat1Label = new System.Windows.Forms.Label();
            this.lng1Label = new System.Windows.Forms.Label();
            this.lat2Label = new System.Windows.Forms.Label();
            this.lng2Label = new System.Windows.Forms.Label();
            this.defaultTab = new System.Windows.Forms.TabPage();
            this.getInformationButton2 = new System.Windows.Forms.Button();
            this.lngToTextBox = new System.Windows.Forms.TextBox();
            this.latToTextBox = new System.Windows.Forms.TextBox();
            this.lngFromTextBox = new System.Windows.Forms.TextBox();
            this.latFromTextBox = new System.Windows.Forms.TextBox();
            this.toLngLabel = new System.Windows.Forms.Label();
            this.toLatLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.lngFromLabel = new System.Windows.Forms.Label();
            this.latFromLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.gmap2 = new GMap.NET.WindowsForms.GMapControl();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.jcdecauxTab = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.nearestTab = new System.Windows.Forms.TabPage();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lng4Label = new System.Windows.Forms.Label();
            this.availableLabel4 = new System.Windows.Forms.Label();
            this.lat4Label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.getRouteBtn3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lng3Label = new System.Windows.Forms.Label();
            this.availableLabel3 = new System.Windows.Forms.Label();
            this.lat3Label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.getInformationBtn3 = new System.Windows.Forms.Button();
            this.nearestListBox = new System.Windows.Forms.ListBox();
            this.stationListBox3 = new System.Windows.Forms.ListBox();
            this.contractListBox3 = new System.Windows.Forms.ListBox();
            this.gmap3 = new GMap.NET.WindowsForms.GMapControl();
            this.splitter6 = new System.Windows.Forms.Splitter();
            this.suggestionTab = new System.Windows.Forms.TabPage();
            this.gmap4 = new GMap.NET.WindowsForms.GMapControl();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.commentAuthorListBox = new System.Windows.Forms.ListBox();
            this.placeAddressLabel = new System.Windows.Forms.Label();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.placeAddressFixedLabel = new System.Windows.Forms.Label();
            this.placeNameFixedLabel = new System.Windows.Forms.Label();
            this.getRouteBtn4 = new System.Windows.Forms.Button();
            this.getInformationBtn4 = new System.Windows.Forms.Button();
            this.getNearestBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.nearestPlaceListBox = new System.Windows.Forms.ListBox();
            this.stationListBox4 = new System.Windows.Forms.ListBox();
            this.contractListBox4 = new System.Windows.Forms.ListBox();
            this.guideTab = new System.Windows.Forms.TabPage();
            this.guideLabel = new System.Windows.Forms.Label();
            this.guideTextBox = new System.Windows.Forms.TextBox();
            this.defaultTab.SuspendLayout();
            this.jcdecauxTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.nearestTab.SuspendLayout();
            this.suggestionTab.SuspendLayout();
            this.guideTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // contractListBox
            // 
            this.contractListBox.FormattingEnabled = true;
            this.contractListBox.Location = new System.Drawing.Point(3, 3);
            this.contractListBox.Name = "contractListBox";
            this.contractListBox.Size = new System.Drawing.Size(224, 251);
            this.contractListBox.TabIndex = 0;
            this.contractListBox.SelectedIndexChanged += new System.EventHandler(this.contractListBox_SelectedIndexChanged);
            // 
            // stationListBox
            // 
            this.stationListBox.FormattingEnabled = true;
            this.stationListBox.Location = new System.Drawing.Point(248, 3);
            this.stationListBox.Name = "stationListBox";
            this.stationListBox.Size = new System.Drawing.Size(256, 251);
            this.stationListBox.TabIndex = 1;
            // 
            // validButton
            // 
            this.validButton.Location = new System.Drawing.Point(906, 429);
            this.validButton.Name = "validButton";
            this.validButton.Size = new System.Drawing.Size(107, 36);
            this.validButton.TabIndex = 2;
            this.validButton.Text = "Get Information";
            this.validButton.UseVisualStyleBackColor = true;
            this.validButton.Click += new System.EventHandler(this.getInformationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Available velibs";
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.Location = new System.Drawing.Point(52, 329);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(18, 20);
            this.availableLabel.TabIndex = 4;
            this.availableLabel.Text = "0";
            // 
            // stationListBox2
            // 
            this.stationListBox2.FormattingEnabled = true;
            this.stationListBox2.Location = new System.Drawing.Point(797, 6);
            this.stationListBox2.Name = "stationListBox2";
            this.stationListBox2.Size = new System.Drawing.Size(251, 251);
            this.stationListBox2.TabIndex = 8;
            // 
            // contractListBox2
            // 
            this.contractListBox2.FormattingEnabled = true;
            this.contractListBox2.Location = new System.Drawing.Point(542, 6);
            this.contractListBox2.Name = "contractListBox2";
            this.contractListBox2.Size = new System.Drawing.Size(240, 251);
            this.contractListBox2.TabIndex = 7;
            this.contractListBox2.SelectedIndexChanged += new System.EventHandler(this.contractListBox2_SelectedIndexChanged);
            // 
            // availableLabel2
            // 
            this.availableLabel2.AutoSize = true;
            this.availableLabel2.Location = new System.Drawing.Point(590, 329);
            this.availableLabel2.Name = "availableLabel2";
            this.availableLabel2.Size = new System.Drawing.Size(18, 20);
            this.availableLabel2.TabIndex = 11;
            this.availableLabel2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Available velibs";
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(1057, 0);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(731, 530);
            this.gmap.TabIndex = 12;
            this.gmap.Zoom = 0D;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Latitude";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Longitude";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(737, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Longitude";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(737, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Latitude";
            // 
            // lat1Label
            // 
            this.lat1Label.AutoSize = true;
            this.lat1Label.Location = new System.Drawing.Point(204, 329);
            this.lat1Label.Name = "lat1Label";
            this.lat1Label.Size = new System.Drawing.Size(18, 20);
            this.lat1Label.TabIndex = 17;
            this.lat1Label.Text = "0";
            // 
            // lng1Label
            // 
            this.lng1Label.AutoSize = true;
            this.lng1Label.Location = new System.Drawing.Point(204, 387);
            this.lng1Label.Name = "lng1Label";
            this.lng1Label.Size = new System.Drawing.Size(18, 20);
            this.lng1Label.TabIndex = 18;
            this.lng1Label.Text = "0";
            // 
            // lat2Label
            // 
            this.lat2Label.AutoSize = true;
            this.lat2Label.Location = new System.Drawing.Point(737, 329);
            this.lat2Label.Name = "lat2Label";
            this.lat2Label.Size = new System.Drawing.Size(18, 20);
            this.lat2Label.TabIndex = 19;
            this.lat2Label.Text = "0";
            // 
            // lng2Label
            // 
            this.lng2Label.AutoSize = true;
            this.lng2Label.Location = new System.Drawing.Point(737, 387);
            this.lng2Label.Name = "lng2Label";
            this.lng2Label.Size = new System.Drawing.Size(18, 20);
            this.lng2Label.TabIndex = 20;
            this.lng2Label.Text = "0";
            // 
            // defaultTab
            // 
            this.defaultTab.Controls.Add(this.getInformationButton2);
            this.defaultTab.Controls.Add(this.lngToTextBox);
            this.defaultTab.Controls.Add(this.latToTextBox);
            this.defaultTab.Controls.Add(this.lngFromTextBox);
            this.defaultTab.Controls.Add(this.latFromTextBox);
            this.defaultTab.Controls.Add(this.toLngLabel);
            this.defaultTab.Controls.Add(this.toLatLabel);
            this.defaultTab.Controls.Add(this.toLabel);
            this.defaultTab.Controls.Add(this.lngFromLabel);
            this.defaultTab.Controls.Add(this.latFromLabel);
            this.defaultTab.Controls.Add(this.fromLabel);
            this.defaultTab.Controls.Add(this.gmap2);
            this.defaultTab.Controls.Add(this.splitter4);
            this.defaultTab.Controls.Add(this.splitter5);
            this.defaultTab.Location = new System.Drawing.Point(4, 22);
            this.defaultTab.Name = "defaultTab";
            this.defaultTab.Padding = new System.Windows.Forms.Padding(3);
            this.defaultTab.Size = new System.Drawing.Size(1791, 492);
            this.defaultTab.TabIndex = 1;
            this.defaultTab.Text = "Default";
            this.defaultTab.UseVisualStyleBackColor = true;
            // 
            // getInformationButton2
            // 
            this.getInformationButton2.Location = new System.Drawing.Point(615, 430);
            this.getInformationButton2.Name = "getInformationButton2";
            this.getInformationButton2.Size = new System.Drawing.Size(97, 30);
            this.getInformationButton2.TabIndex = 13;
            this.getInformationButton2.Text = "Get Information";
            this.getInformationButton2.UseVisualStyleBackColor = true;
            this.getInformationButton2.Click += new System.EventHandler(this.getInformationButton2_Click);
            // 
            // lngToTextBox
            // 
            this.lngToTextBox.Location = new System.Drawing.Point(453, 117);
            this.lngToTextBox.Name = "lngToTextBox";
            this.lngToTextBox.Size = new System.Drawing.Size(142, 26);
            this.lngToTextBox.TabIndex = 12;
            // 
            // latToTextBox
            // 
            this.latToTextBox.Location = new System.Drawing.Point(453, 78);
            this.latToTextBox.Name = "latToTextBox";
            this.latToTextBox.Size = new System.Drawing.Size(142, 26);
            this.latToTextBox.TabIndex = 11;
            // 
            // lngFromTextBox
            // 
            this.lngFromTextBox.Location = new System.Drawing.Point(125, 117);
            this.lngFromTextBox.Name = "lngFromTextBox";
            this.lngFromTextBox.Size = new System.Drawing.Size(137, 26);
            this.lngFromTextBox.TabIndex = 10;
            // 
            // latFromTextBox
            // 
            this.latFromTextBox.Location = new System.Drawing.Point(125, 78);
            this.latFromTextBox.Name = "latFromTextBox";
            this.latFromTextBox.Size = new System.Drawing.Size(137, 26);
            this.latFromTextBox.TabIndex = 9;
            // 
            // toLngLabel
            // 
            this.toLngLabel.AutoSize = true;
            this.toLngLabel.Location = new System.Drawing.Point(369, 120);
            this.toLngLabel.Name = "toLngLabel";
            this.toLngLabel.Size = new System.Drawing.Size(80, 20);
            this.toLngLabel.TabIndex = 8;
            this.toLngLabel.Text = "Longitude";
            // 
            // toLatLabel
            // 
            this.toLatLabel.AutoSize = true;
            this.toLatLabel.Location = new System.Drawing.Point(369, 81);
            this.toLatLabel.Name = "toLatLabel";
            this.toLatLabel.Size = new System.Drawing.Size(67, 20);
            this.toLatLabel.TabIndex = 7;
            this.toLatLabel.Text = "Latitude";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(369, 51);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(30, 20);
            this.toLabel.TabIndex = 6;
            this.toLabel.Text = "TO";
            // 
            // lngFromLabel
            // 
            this.lngFromLabel.AutoSize = true;
            this.lngFromLabel.Location = new System.Drawing.Point(63, 120);
            this.lngFromLabel.Name = "lngFromLabel";
            this.lngFromLabel.Size = new System.Drawing.Size(80, 20);
            this.lngFromLabel.TabIndex = 4;
            this.lngFromLabel.Text = "Longitude";
            // 
            // latFromLabel
            // 
            this.latFromLabel.AutoSize = true;
            this.latFromLabel.Location = new System.Drawing.Point(63, 81);
            this.latFromLabel.Name = "latFromLabel";
            this.latFromLabel.Size = new System.Drawing.Size(67, 20);
            this.latFromLabel.TabIndex = 3;
            this.latFromLabel.Text = "Latitude";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(63, 51);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(56, 20);
            this.fromLabel.TabIndex = 2;
            this.fromLabel.Text = "FROM";
            // 
            // gmap2
            // 
            this.gmap2.Bearing = 0F;
            this.gmap2.CanDragMap = true;
            this.gmap2.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap2.GrayScaleMode = false;
            this.gmap2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap2.LevelsKeepInMemory = 5;
            this.gmap2.Location = new System.Drawing.Point(779, 3);
            this.gmap2.MarkersEnabled = true;
            this.gmap2.MaxZoom = 2;
            this.gmap2.MinZoom = 2;
            this.gmap2.MouseWheelZoomEnabled = true;
            this.gmap2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap2.Name = "gmap2";
            this.gmap2.NegativeMode = false;
            this.gmap2.PolygonsEnabled = true;
            this.gmap2.RetryLoadTile = 0;
            this.gmap2.RoutesEnabled = true;
            this.gmap2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap2.ShowTileGridLines = false;
            this.gmap2.Size = new System.Drawing.Size(1006, 483);
            this.gmap2.TabIndex = 1;
            this.gmap2.Zoom = 0D;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(773, 3);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(770, 486);
            this.splitter4.TabIndex = 0;
            this.splitter4.TabStop = false;
            // 
            // splitter5
            // 
            this.splitter5.Location = new System.Drawing.Point(3, 3);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(770, 486);
            this.splitter5.TabIndex = 5;
            this.splitter5.TabStop = false;
            // 
            // jcdecauxTab
            // 
            this.jcdecauxTab.Controls.Add(this.splitter1);
            this.jcdecauxTab.Controls.Add(this.gmap);
            this.jcdecauxTab.Controls.Add(this.contractListBox);
            this.jcdecauxTab.Controls.Add(this.lng2Label);
            this.jcdecauxTab.Controls.Add(this.validButton);
            this.jcdecauxTab.Controls.Add(this.stationListBox);
            this.jcdecauxTab.Controls.Add(this.lat2Label);
            this.jcdecauxTab.Controls.Add(this.label1);
            this.jcdecauxTab.Controls.Add(this.label9);
            this.jcdecauxTab.Controls.Add(this.lng1Label);
            this.jcdecauxTab.Controls.Add(this.label8);
            this.jcdecauxTab.Controls.Add(this.availableLabel);
            this.jcdecauxTab.Controls.Add(this.lat1Label);
            this.jcdecauxTab.Controls.Add(this.availableLabel2);
            this.jcdecauxTab.Controls.Add(this.label6);
            this.jcdecauxTab.Controls.Add(this.label3);
            this.jcdecauxTab.Controls.Add(this.label7);
            this.jcdecauxTab.Controls.Add(this.stationListBox2);
            this.jcdecauxTab.Controls.Add(this.contractListBox2);
            this.jcdecauxTab.Controls.Add(this.splitter2);
            this.jcdecauxTab.Controls.Add(this.splitter3);
            this.jcdecauxTab.Location = new System.Drawing.Point(4, 22);
            this.jcdecauxTab.Name = "jcdecauxTab";
            this.jcdecauxTab.Padding = new System.Windows.Forms.Padding(3);
            this.jcdecauxTab.Size = new System.Drawing.Size(1791, 492);
            this.jcdecauxTab.TabIndex = 0;
            this.jcdecauxTab.Text = "JCDecaux";
            this.jcdecauxTab.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(1054, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 486);
            this.splitter1.TabIndex = 21;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(536, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(518, 486);
            this.splitter2.TabIndex = 22;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(3, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(533, 486);
            this.splitter3.TabIndex = 19;
            this.splitter3.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.defaultTab);
            this.tabControl1.Controls.Add(this.jcdecauxTab);
            this.tabControl1.Controls.Add(this.nearestTab);
            this.tabControl1.Controls.Add(this.suggestionTab);
            this.tabControl1.Controls.Add(this.guideTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1799, 518);
            this.tabControl1.TabIndex = 21;
            // 
            // nearestTab
            // 
            this.nearestTab.Controls.Add(this.distanceLabel);
            this.nearestTab.Controls.Add(this.label5);
            this.nearestTab.Controls.Add(this.label4);
            this.nearestTab.Controls.Add(this.lng4Label);
            this.nearestTab.Controls.Add(this.availableLabel4);
            this.nearestTab.Controls.Add(this.lat4Label);
            this.nearestTab.Controls.Add(this.label14);
            this.nearestTab.Controls.Add(this.label15);
            this.nearestTab.Controls.Add(this.getRouteBtn3);
            this.nearestTab.Controls.Add(this.label2);
            this.nearestTab.Controls.Add(this.lng3Label);
            this.nearestTab.Controls.Add(this.availableLabel3);
            this.nearestTab.Controls.Add(this.lat3Label);
            this.nearestTab.Controls.Add(this.label11);
            this.nearestTab.Controls.Add(this.label12);
            this.nearestTab.Controls.Add(this.getInformationBtn3);
            this.nearestTab.Controls.Add(this.nearestListBox);
            this.nearestTab.Controls.Add(this.stationListBox3);
            this.nearestTab.Controls.Add(this.contractListBox3);
            this.nearestTab.Controls.Add(this.gmap3);
            this.nearestTab.Controls.Add(this.splitter6);
            this.nearestTab.Location = new System.Drawing.Point(4, 22);
            this.nearestTab.Name = "nearestTab";
            this.nearestTab.Size = new System.Drawing.Size(1791, 492);
            this.nearestTab.TabIndex = 3;
            this.nearestTab.Text = "Nearests";
            this.nearestTab.UseVisualStyleBackColor = true;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(576, 401);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(18, 20);
            this.distanceLabel.TabIndex = 35;
            this.distanceLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Distance (km)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Available velibs";
            // 
            // lng4Label
            // 
            this.lng4Label.AutoSize = true;
            this.lng4Label.Location = new System.Drawing.Point(728, 401);
            this.lng4Label.Name = "lng4Label";
            this.lng4Label.Size = new System.Drawing.Size(18, 20);
            this.lng4Label.TabIndex = 33;
            this.lng4Label.Text = "0";
            // 
            // availableLabel4
            // 
            this.availableLabel4.AutoSize = true;
            this.availableLabel4.Location = new System.Drawing.Point(576, 343);
            this.availableLabel4.Name = "availableLabel4";
            this.availableLabel4.Size = new System.Drawing.Size(18, 20);
            this.availableLabel4.TabIndex = 29;
            this.availableLabel4.Text = "0";
            // 
            // lat4Label
            // 
            this.lat4Label.AutoSize = true;
            this.lat4Label.Location = new System.Drawing.Point(728, 343);
            this.lat4Label.Name = "lat4Label";
            this.lat4Label.Size = new System.Drawing.Size(18, 20);
            this.lat4Label.TabIndex = 32;
            this.lat4Label.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(728, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Latitude";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(728, 375);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Longitude";
            // 
            // getRouteBtn3
            // 
            this.getRouteBtn3.Location = new System.Drawing.Point(775, 443);
            this.getRouteBtn3.Name = "getRouteBtn3";
            this.getRouteBtn3.Size = new System.Drawing.Size(107, 36);
            this.getRouteBtn3.TabIndex = 27;
            this.getRouteBtn3.Text = "Get Route";
            this.getRouteBtn3.UseVisualStyleBackColor = true;
            this.getRouteBtn3.Click += new System.EventHandler(this.getRouteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Available velibs";
            // 
            // lng3Label
            // 
            this.lng3Label.AutoSize = true;
            this.lng3Label.Location = new System.Drawing.Point(265, 405);
            this.lng3Label.Name = "lng3Label";
            this.lng3Label.Size = new System.Drawing.Size(18, 20);
            this.lng3Label.TabIndex = 25;
            this.lng3Label.Text = "0";
            // 
            // availableLabel3
            // 
            this.availableLabel3.AutoSize = true;
            this.availableLabel3.Location = new System.Drawing.Point(113, 347);
            this.availableLabel3.Name = "availableLabel3";
            this.availableLabel3.Size = new System.Drawing.Size(18, 20);
            this.availableLabel3.TabIndex = 21;
            this.availableLabel3.Text = "0";
            // 
            // lat3Label
            // 
            this.lat3Label.AutoSize = true;
            this.lat3Label.Location = new System.Drawing.Point(265, 347);
            this.lat3Label.Name = "lat3Label";
            this.lat3Label.Size = new System.Drawing.Size(18, 20);
            this.lat3Label.TabIndex = 24;
            this.lat3Label.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Latitude";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(265, 379);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Longitude";
            // 
            // getInformationBtn3
            // 
            this.getInformationBtn3.Location = new System.Drawing.Point(171, 443);
            this.getInformationBtn3.Name = "getInformationBtn3";
            this.getInformationBtn3.Size = new System.Drawing.Size(107, 36);
            this.getInformationBtn3.TabIndex = 6;
            this.getInformationBtn3.Text = "Get Information";
            this.getInformationBtn3.UseVisualStyleBackColor = true;
            this.getInformationBtn3.Click += new System.EventHandler(this.getInformationButton3_Click);
            // 
            // nearestListBox
            // 
            this.nearestListBox.FormattingEnabled = true;
            this.nearestListBox.Location = new System.Drawing.Point(549, 3);
            this.nearestListBox.Name = "nearestListBox";
            this.nearestListBox.Size = new System.Drawing.Size(333, 277);
            this.nearestListBox.TabIndex = 5;
            // 
            // stationListBox3
            // 
            this.stationListBox3.FormattingEnabled = true;
            this.stationListBox3.Location = new System.Drawing.Point(258, 0);
            this.stationListBox3.Name = "stationListBox3";
            this.stationListBox3.Size = new System.Drawing.Size(217, 277);
            this.stationListBox3.TabIndex = 4;
            // 
            // contractListBox3
            // 
            this.contractListBox3.FormattingEnabled = true;
            this.contractListBox3.Location = new System.Drawing.Point(3, 3);
            this.contractListBox3.Name = "contractListBox3";
            this.contractListBox3.Size = new System.Drawing.Size(217, 277);
            this.contractListBox3.TabIndex = 3;
            this.contractListBox3.SelectedIndexChanged += new System.EventHandler(this.contractListBox3_SelectedIndexChanged);
            // 
            // gmap3
            // 
            this.gmap3.Bearing = 0F;
            this.gmap3.CanDragMap = true;
            this.gmap3.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap3.GrayScaleMode = false;
            this.gmap3.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap3.LevelsKeepInMemory = 5;
            this.gmap3.Location = new System.Drawing.Point(911, 0);
            this.gmap3.MarkersEnabled = true;
            this.gmap3.MaxZoom = 2;
            this.gmap3.MinZoom = 2;
            this.gmap3.MouseWheelZoomEnabled = true;
            this.gmap3.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap3.Name = "gmap3";
            this.gmap3.NegativeMode = false;
            this.gmap3.PolygonsEnabled = true;
            this.gmap3.RetryLoadTile = 0;
            this.gmap3.RoutesEnabled = true;
            this.gmap3.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap3.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap3.ShowTileGridLines = false;
            this.gmap3.Size = new System.Drawing.Size(879, 492);
            this.gmap3.TabIndex = 2;
            this.gmap3.Zoom = 0D;
            // 
            // splitter6
            // 
            this.splitter6.Location = new System.Drawing.Point(0, 0);
            this.splitter6.Name = "splitter6";
            this.splitter6.Size = new System.Drawing.Size(905, 492);
            this.splitter6.TabIndex = 0;
            this.splitter6.TabStop = false;
            // 
            // suggestionTab
            // 
            this.suggestionTab.Controls.Add(this.gmap4);
            this.suggestionTab.Controls.Add(this.commentTextBox);
            this.suggestionTab.Controls.Add(this.commentAuthorListBox);
            this.suggestionTab.Controls.Add(this.placeAddressLabel);
            this.suggestionTab.Controls.Add(this.placeNameLabel);
            this.suggestionTab.Controls.Add(this.placeAddressFixedLabel);
            this.suggestionTab.Controls.Add(this.placeNameFixedLabel);
            this.suggestionTab.Controls.Add(this.getRouteBtn4);
            this.suggestionTab.Controls.Add(this.getInformationBtn4);
            this.suggestionTab.Controls.Add(this.getNearestBtn);
            this.suggestionTab.Controls.Add(this.label10);
            this.suggestionTab.Controls.Add(this.radiusTextBox);
            this.suggestionTab.Controls.Add(this.nearestPlaceListBox);
            this.suggestionTab.Controls.Add(this.stationListBox4);
            this.suggestionTab.Controls.Add(this.contractListBox4);
            this.suggestionTab.Location = new System.Drawing.Point(4, 22);
            this.suggestionTab.Name = "suggestionTab";
            this.suggestionTab.Size = new System.Drawing.Size(1791, 492);
            this.suggestionTab.TabIndex = 4;
            this.suggestionTab.Text = "Suggestion";
            this.suggestionTab.UseVisualStyleBackColor = true;
            // 
            // gmap4
            // 
            this.gmap4.Bearing = 0F;
            this.gmap4.CanDragMap = true;
            this.gmap4.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap4.GrayScaleMode = false;
            this.gmap4.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap4.LevelsKeepInMemory = 5;
            this.gmap4.Location = new System.Drawing.Point(948, 0);
            this.gmap4.MarkersEnabled = true;
            this.gmap4.MaxZoom = 2;
            this.gmap4.MinZoom = 2;
            this.gmap4.MouseWheelZoomEnabled = true;
            this.gmap4.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap4.Name = "gmap4";
            this.gmap4.NegativeMode = false;
            this.gmap4.PolygonsEnabled = true;
            this.gmap4.RetryLoadTile = 0;
            this.gmap4.RoutesEnabled = true;
            this.gmap4.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap4.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap4.ShowTileGridLines = false;
            this.gmap4.Size = new System.Drawing.Size(840, 489);
            this.gmap4.TabIndex = 16;
            this.gmap4.Zoom = 0D;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(717, 309);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(225, 121);
            this.commentTextBox.TabIndex = 15;
            // 
            // commentAuthorListBox
            // 
            this.commentAuthorListBox.FormattingEnabled = true;
            this.commentAuthorListBox.Location = new System.Drawing.Point(598, 309);
            this.commentAuthorListBox.Name = "commentAuthorListBox";
            this.commentAuthorListBox.Size = new System.Drawing.Size(113, 121);
            this.commentAuthorListBox.TabIndex = 14;
            this.commentAuthorListBox.SelectedIndexChanged += new System.EventHandler(this.loadComment);
            // 
            // placeAddressLabel
            // 
            this.placeAddressLabel.AutoSize = true;
            this.placeAddressLabel.Location = new System.Drawing.Point(358, 373);
            this.placeAddressLabel.Name = "placeAddressLabel";
            this.placeAddressLabel.Size = new System.Drawing.Size(0, 20);
            this.placeAddressLabel.TabIndex = 12;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Location = new System.Drawing.Point(358, 350);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(0, 20);
            this.placeNameLabel.TabIndex = 11;
            // 
            // placeAddressFixedLabel
            // 
            this.placeAddressFixedLabel.AutoSize = true;
            this.placeAddressFixedLabel.Location = new System.Drawing.Point(296, 373);
            this.placeAddressFixedLabel.Name = "placeAddressFixedLabel";
            this.placeAddressFixedLabel.Size = new System.Drawing.Size(68, 20);
            this.placeAddressFixedLabel.TabIndex = 9;
            this.placeAddressFixedLabel.Text = "Address";
            // 
            // placeNameFixedLabel
            // 
            this.placeNameFixedLabel.AutoSize = true;
            this.placeNameFixedLabel.Location = new System.Drawing.Point(296, 350);
            this.placeNameFixedLabel.Name = "placeNameFixedLabel";
            this.placeNameFixedLabel.Size = new System.Drawing.Size(51, 20);
            this.placeNameFixedLabel.TabIndex = 8;
            this.placeNameFixedLabel.Text = "Name";
            // 
            // getRouteBtn4
            // 
            this.getRouteBtn4.Location = new System.Drawing.Point(800, 457);
            this.getRouteBtn4.Name = "getRouteBtn4";
            this.getRouteBtn4.Size = new System.Drawing.Size(107, 32);
            this.getRouteBtn4.TabIndex = 7;
            this.getRouteBtn4.Text = "Get Route";
            this.getRouteBtn4.UseVisualStyleBackColor = true;
            this.getRouteBtn4.Click += new System.EventHandler(this.getRouteBtn4_Click);
            // 
            // getInformationBtn4
            // 
            this.getInformationBtn4.Location = new System.Drawing.Point(598, 457);
            this.getInformationBtn4.Name = "getInformationBtn4";
            this.getInformationBtn4.Size = new System.Drawing.Size(158, 32);
            this.getInformationBtn4.TabIndex = 6;
            this.getInformationBtn4.Text = "Get Information";
            this.getInformationBtn4.UseVisualStyleBackColor = true;
            this.getInformationBtn4.Click += new System.EventHandler(this.getInformationBtn4_Click);
            // 
            // getNearestBtn
            // 
            this.getNearestBtn.Location = new System.Drawing.Point(23, 457);
            this.getNearestBtn.Name = "getNearestBtn";
            this.getNearestBtn.Size = new System.Drawing.Size(125, 32);
            this.getNearestBtn.TabIndex = 5;
            this.getNearestBtn.Text = "Get nearest places";
            this.getNearestBtn.UseVisualStyleBackColor = true;
            this.getNearestBtn.Click += new System.EventHandler(this.getNearestPlaceBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Radius";
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(81, 344);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(67, 26);
            this.radiusTextBox.TabIndex = 3;
            // 
            // nearestPlaceListBox
            // 
            this.nearestPlaceListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nearestPlaceListBox.FormattingEnabled = true;
            this.nearestPlaceListBox.Location = new System.Drawing.Point(573, 4);
            this.nearestPlaceListBox.Name = "nearestPlaceListBox";
            this.nearestPlaceListBox.Size = new System.Drawing.Size(209, 273);
            this.nearestPlaceListBox.TabIndex = 2;
            // 
            // stationListBox4
            // 
            this.stationListBox4.FormattingEnabled = true;
            this.stationListBox4.Location = new System.Drawing.Point(245, 0);
            this.stationListBox4.Name = "stationListBox4";
            this.stationListBox4.Size = new System.Drawing.Size(203, 277);
            this.stationListBox4.TabIndex = 1;
            // 
            // contractListBox4
            // 
            this.contractListBox4.FormattingEnabled = true;
            this.contractListBox4.Location = new System.Drawing.Point(3, 3);
            this.contractListBox4.Name = "contractListBox4";
            this.contractListBox4.Size = new System.Drawing.Size(193, 277);
            this.contractListBox4.TabIndex = 0;
            this.contractListBox4.SelectedIndexChanged += new System.EventHandler(this.contractListBox4_SelectedIndexChanged);
            // 
            // guideTab
            // 
            this.guideTab.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.guideTab.Controls.Add(this.guideLabel);
            this.guideTab.Controls.Add(this.guideTextBox);
            this.guideTab.Location = new System.Drawing.Point(4, 22);
            this.guideTab.Name = "guideTab";
            this.guideTab.Size = new System.Drawing.Size(1791, 492);
            this.guideTab.TabIndex = 2;
            this.guideTab.Text = "Guide";
            this.guideTab.UseVisualStyleBackColor = true;
            // 
            // guideLabel
            // 
            this.guideLabel.AutoSize = true;
            this.guideLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.guideLabel.Location = new System.Drawing.Point(8, 36);
            this.guideLabel.Name = "guideLabel";
            this.guideLabel.Size = new System.Drawing.Size(98, 20);
            this.guideLabel.TabIndex = 1;
            this.guideLabel.Text = "How to use?";
            // 
            // guideTextBox
            // 
            this.guideTextBox.Location = new System.Drawing.Point(7, 77);
            this.guideTextBox.Multiline = true;
            this.guideTextBox.Name = "guideTextBox";
            this.guideTextBox.ReadOnly = true;
            this.guideTextBox.Size = new System.Drawing.Size(643, 208);
            this.guideTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1284, 530);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.defaultTab.ResumeLayout(false);
            this.defaultTab.PerformLayout();
            this.jcdecauxTab.ResumeLayout(false);
            this.jcdecauxTab.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.nearestTab.ResumeLayout(false);
            this.nearestTab.PerformLayout();
            this.suggestionTab.ResumeLayout(false);
            this.suggestionTab.PerformLayout();
            this.guideTab.ResumeLayout(false);
            this.guideTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.ListBox contractListBox;
        private System.Windows.Forms.ListBox stationListBox;
        private System.Windows.Forms.Button validButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label availableLabel;
        private System.Windows.Forms.ListBox stationListBox2;
        private System.Windows.Forms.ListBox contractListBox2;
        private System.Windows.Forms.Label availableLabel2;
        private System.Windows.Forms.Label label3;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lat1Label;
        private System.Windows.Forms.Label lng1Label;
        private System.Windows.Forms.Label lat2Label;
        private System.Windows.Forms.Label lng2Label;
        private System.Windows.Forms.TabPage defaultTab;
        private System.Windows.Forms.TabPage jcdecauxTab;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label fromLabel;
        private GMap.NET.WindowsForms.GMapControl gmap2;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Label latFromLabel;
        private System.Windows.Forms.Label toLngLabel;
        private System.Windows.Forms.Label toLatLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Label lngFromLabel;
        private System.Windows.Forms.TextBox lngToTextBox;
        private System.Windows.Forms.TextBox latToTextBox;
        private System.Windows.Forms.TextBox lngFromTextBox;
        private System.Windows.Forms.TextBox latFromTextBox;
        private System.Windows.Forms.Button getInformationButton2;
        private System.Windows.Forms.TabPage guideTab;
        private System.Windows.Forms.Label guideLabel;
        private System.Windows.Forms.TextBox guideTextBox;
        private System.Windows.Forms.TabPage nearestTab;
        private System.Windows.Forms.Button getRouteBtn3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lng3Label;
        private System.Windows.Forms.Label availableLabel3;
        private System.Windows.Forms.Label lat3Label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button getInformationBtn3;
        private System.Windows.Forms.ListBox nearestListBox;
        private System.Windows.Forms.ListBox stationListBox3;
        private System.Windows.Forms.ListBox contractListBox3;
        private GMap.NET.WindowsForms.GMapControl gmap3;
        private System.Windows.Forms.Splitter splitter6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lng4Label;
        private System.Windows.Forms.Label availableLabel4;
        private System.Windows.Forms.Label lat4Label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage suggestionTab;
        private System.Windows.Forms.Label placeAddressLabel;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.Label placeAddressFixedLabel;
        private System.Windows.Forms.Label placeNameFixedLabel;
        private System.Windows.Forms.Button getRouteBtn4;
        private System.Windows.Forms.Button getInformationBtn4;
        private System.Windows.Forms.Button getNearestBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.ListBox nearestPlaceListBox;
        private System.Windows.Forms.ListBox stationListBox4;
        private System.Windows.Forms.ListBox contractListBox4;
        private System.Windows.Forms.ListBox commentAuthorListBox;
        private GMap.NET.WindowsForms.GMapControl gmap4;
        private System.Windows.Forms.TextBox commentTextBox;
    }
}

