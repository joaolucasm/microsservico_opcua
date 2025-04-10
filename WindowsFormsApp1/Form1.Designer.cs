namespace microsservico_opcua
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBoxConexao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxCorrente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxTensao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxAngTensao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxFreq = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxPotRealVAr = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBoxPotApar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBoxPotRealWw = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBoxFatorPot = new System.Windows.Forms.TextBox();
            this.salvarBotton = new System.Windows.Forms.Button();
            this.numericUpDownTaxLeitura = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxDns = new System.Windows.Forms.TextBox();
            this.cbTipoIED = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxIp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBoxLocal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBoxCircuito = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBoxMac = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbTipoAtivo = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbProtocolo = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbPausado = new System.Windows.Forms.ComboBox();
            this.numericUpDownCodId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaxLeitura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCodId)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxConexao
            // 
            this.txtBoxConexao.Location = new System.Drawing.Point(259, 465);
            this.txtBoxConexao.Name = "txtBoxConexao";
            this.txtBoxConexao.Size = new System.Drawing.Size(481, 20);
            this.txtBoxConexao.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Link de conexão servidor OPC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Corrente NodeID";
            // 
            // txtBoxCorrente
            // 
            this.txtBoxCorrente.Location = new System.Drawing.Point(324, 240);
            this.txtBoxCorrente.Name = "txtBoxCorrente";
            this.txtBoxCorrente.Size = new System.Drawing.Size(150, 20);
            this.txtBoxCorrente.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(321, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tensão NodeID";
            // 
            // txtBoxTensao
            // 
            this.txtBoxTensao.Location = new System.Drawing.Point(324, 292);
            this.txtBoxTensao.Name = "txtBoxTensao";
            this.txtBoxTensao.Size = new System.Drawing.Size(150, 20);
            this.txtBoxTensao.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(324, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Angulo tensão NodeID";
            // 
            // txtBoxAngTensao
            // 
            this.txtBoxAngTensao.Location = new System.Drawing.Point(324, 349);
            this.txtBoxAngTensao.Name = "txtBoxAngTensao";
            this.txtBoxAngTensao.Size = new System.Drawing.Size(150, 20);
            this.txtBoxAngTensao.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(324, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Frequência NodeID";
            // 
            // txtBoxFreq
            // 
            this.txtBoxFreq.Location = new System.Drawing.Point(324, 403);
            this.txtBoxFreq.Name = "txtBoxFreq";
            this.txtBoxFreq.Size = new System.Drawing.Size(150, 20);
            this.txtBoxFreq.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(515, 384);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "Potência RealVAr Node ID";
            // 
            // txtBoxPotRealVAr
            // 
            this.txtBoxPotRealVAr.Location = new System.Drawing.Point(518, 403);
            this.txtBoxPotRealVAr.Name = "txtBoxPotRealVAr";
            this.txtBoxPotRealVAr.Size = new System.Drawing.Size(150, 20);
            this.txtBoxPotRealVAr.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(515, 330);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "Potência Aparente NodeID";
            // 
            // txtBoxPotApar
            // 
            this.txtBoxPotApar.Location = new System.Drawing.Point(518, 349);
            this.txtBoxPotApar.Name = "txtBoxPotApar";
            this.txtBoxPotApar.Size = new System.Drawing.Size(150, 20);
            this.txtBoxPotApar.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(515, 273);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 16);
            this.label17.TabIndex = 26;
            this.label17.Text = "Potência Real Ww NodeID";
            // 
            // txtBoxPotRealWw
            // 
            this.txtBoxPotRealWw.Location = new System.Drawing.Point(518, 292);
            this.txtBoxPotRealWw.Name = "txtBoxPotRealWw";
            this.txtBoxPotRealWw.Size = new System.Drawing.Size(150, 20);
            this.txtBoxPotRealWw.TabIndex = 25;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(515, 221);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 16);
            this.label19.TabIndex = 22;
            this.label19.Text = "Fator Potência NodeID";
            // 
            // txtBoxFatorPot
            // 
            this.txtBoxFatorPot.Location = new System.Drawing.Point(518, 240);
            this.txtBoxFatorPot.Name = "txtBoxFatorPot";
            this.txtBoxFatorPot.Size = new System.Drawing.Size(150, 20);
            this.txtBoxFatorPot.TabIndex = 21;
            // 
            // salvarBotton
            // 
            this.salvarBotton.BackColor = System.Drawing.Color.Gray;
            this.salvarBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarBotton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salvarBotton.Location = new System.Drawing.Point(429, 491);
            this.salvarBotton.Name = "salvarBotton";
            this.salvarBotton.Size = new System.Drawing.Size(122, 45);
            this.salvarBotton.TabIndex = 37;
            this.salvarBotton.Text = "Salvar";
            this.salvarBotton.UseVisualStyleBackColor = false;
            this.salvarBotton.Click += new System.EventHandler(this.salvarBotton_Click);
            // 
            // numericUpDownTaxLeitura
            // 
            this.numericUpDownTaxLeitura.Location = new System.Drawing.Point(19, 51);
            this.numericUpDownTaxLeitura.Name = "numericUpDownTaxLeitura";
            this.numericUpDownTaxLeitura.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownTaxLeitura.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Taxa de leitura (segundos):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "COD ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "DNSIot:";
            // 
            // txtBoxDns
            // 
            this.txtBoxDns.Location = new System.Drawing.Point(348, 51);
            this.txtBoxDns.Name = "txtBoxDns";
            this.txtBoxDns.Size = new System.Drawing.Size(150, 20);
            this.txtBoxDns.TabIndex = 43;
            // 
            // cbTipoIED
            // 
            this.cbTipoIED.DropDownWidth = 150;
            this.cbTipoIED.Enabled = false;
            this.cbTipoIED.FormattingEnabled = true;
            this.cbTipoIED.Location = new System.Drawing.Point(504, 50);
            this.cbTipoIED.Name = "cbTipoIED";
            this.cbTipoIED.Size = new System.Drawing.Size(150, 21);
            this.cbTipoIED.TabIndex = 45;
            this.cbTipoIED.Text = "RELE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(501, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "Tipo IED:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(660, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "IP:";
            // 
            // txtBoxIp
            // 
            this.txtBoxIp.Location = new System.Drawing.Point(663, 50);
            this.txtBoxIp.Name = "txtBoxIp";
            this.txtBoxIp.Size = new System.Drawing.Size(150, 20);
            this.txtBoxIp.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(820, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "Escopo:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownWidth = 150;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "RELE"});
            this.comboBox1.Location = new System.Drawing.Point(823, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(185, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 16);
            this.label14.TabIndex = 54;
            this.label14.Text = "Local:";
            // 
            // txtBoxLocal
            // 
            this.txtBoxLocal.Location = new System.Drawing.Point(188, 118);
            this.txtBoxLocal.Name = "txtBoxLocal";
            this.txtBoxLocal.Size = new System.Drawing.Size(150, 20);
            this.txtBoxLocal.TabIndex = 53;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 16);
            this.label16.TabIndex = 52;
            this.label16.Text = "Circuito:";
            // 
            // txtBoxCircuito
            // 
            this.txtBoxCircuito.Location = new System.Drawing.Point(19, 118);
            this.txtBoxCircuito.Name = "txtBoxCircuito";
            this.txtBoxCircuito.Size = new System.Drawing.Size(150, 20);
            this.txtBoxCircuito.TabIndex = 51;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(345, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 16);
            this.label18.TabIndex = 56;
            this.label18.Text = "Mac:";
            // 
            // txtBoxMac
            // 
            this.txtBoxMac.Location = new System.Drawing.Point(348, 118);
            this.txtBoxMac.Name = "txtBoxMac";
            this.txtBoxMac.Size = new System.Drawing.Size(150, 20);
            this.txtBoxMac.TabIndex = 55;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(501, 99);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 16);
            this.label20.TabIndex = 58;
            this.label20.Text = "Tipo ativo associado:";
            // 
            // cbTipoAtivo
            // 
            this.cbTipoAtivo.DropDownWidth = 150;
            this.cbTipoAtivo.FormattingEnabled = true;
            this.cbTipoAtivo.Items.AddRange(new object[] {
            "Cabo MT/AT",
            "Subestação",
            "Alimentador genérico",
            "Carga genérica",
            "Unid. transformadora de SE",
            "Ligações de SEs",
            "IED genérico",
            "Seccionadora",
            "Disjuntor",
            "Barramento"});
            this.cbTipoAtivo.Location = new System.Drawing.Point(504, 118);
            this.cbTipoAtivo.Name = "cbTipoAtivo";
            this.cbTipoAtivo.Size = new System.Drawing.Size(150, 21);
            this.cbTipoAtivo.TabIndex = 57;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(660, 99);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 16);
            this.label21.TabIndex = 60;
            this.label21.Text = "Protocolo:";
            // 
            // cbProtocolo
            // 
            this.cbProtocolo.DropDownWidth = 150;
            this.cbProtocolo.Enabled = false;
            this.cbProtocolo.FormattingEnabled = true;
            this.cbProtocolo.Items.AddRange(new object[] {
            "OPC UA"});
            this.cbProtocolo.Location = new System.Drawing.Point(663, 118);
            this.cbProtocolo.Name = "cbProtocolo";
            this.cbProtocolo.Size = new System.Drawing.Size(150, 21);
            this.cbProtocolo.TabIndex = 59;
            this.cbProtocolo.Text = "OPC UA";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(440, 158);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 16);
            this.label22.TabIndex = 62;
            this.label22.Text = "Iniciar pausado:";
            // 
            // cbPausado
            // 
            this.cbPausado.FormattingEnabled = true;
            this.cbPausado.Items.AddRange(new object[] {
            "Não",
            "Sim"});
            this.cbPausado.Location = new System.Drawing.Point(411, 177);
            this.cbPausado.Name = "cbPausado";
            this.cbPausado.Size = new System.Drawing.Size(150, 21);
            this.cbPausado.TabIndex = 63;
            // 
            // numericUpDownCodId
            // 
            this.numericUpDownCodId.Location = new System.Drawing.Point(188, 52);
            this.numericUpDownCodId.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownCodId.Name = "numericUpDownCodId";
            this.numericUpDownCodId.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownCodId.TabIndex = 64;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(996, 546);
            this.Controls.Add(this.numericUpDownCodId);
            this.Controls.Add(this.cbPausado);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cbProtocolo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cbTipoAtivo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtBoxMac);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtBoxLocal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtBoxCircuito);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxIp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbTipoIED);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxDns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownTaxLeitura);
            this.Controls.Add(this.salvarBotton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBoxPotRealVAr);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBoxPotApar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtBoxPotRealWw);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtBoxFatorPot);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBoxFreq);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxAngTensao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxTensao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxCorrente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxConexao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Registro de IED e relés";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaxLeitura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCodId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxConexao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxCorrente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxTensao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxAngTensao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxFreq;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoxPotRealVAr;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBoxPotApar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBoxPotRealWw;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtBoxFatorPot;
        private System.Windows.Forms.Button salvarBotton;
        private System.Windows.Forms.NumericUpDown numericUpDownTaxLeitura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxDns;
        private System.Windows.Forms.ComboBox cbTipoIED;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxIp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBoxLocal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBoxCircuito;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBoxMac;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbTipoAtivo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbProtocolo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbPausado;
        private System.Windows.Forms.NumericUpDown numericUpDownCodId;
    }
}

