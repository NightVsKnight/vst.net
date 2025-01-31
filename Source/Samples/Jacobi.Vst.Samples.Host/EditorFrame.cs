﻿using System.Drawing;
using System.Windows.Forms;

namespace Jacobi.Vst.Samples.Host
{
    /// <summary>
    /// The frame in which a custom plugin editor UI is displayed.
    /// </summary>
    public partial class EditorFrame : Form
    {
        /// <summary>
        /// Default ctor.
        /// </summary>
        public EditorFrame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the Plugin Command Stub.
        /// </summary>
        public Jacobi.Vst.Core.Host.IVstPluginCommandStub PluginCommandStub { get; set; }

        /// <summary>
        /// Shows the custom plugin editor UI.
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        public new DialogResult ShowDialog(IWin32Window owner)
        {
            PluginCommandStub.Commands.EditorOpen(this.Handle);
            return base.ShowDialog(owner);
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);

            if (!e.Cancel)
            {
                PluginCommandStub.Commands.EditorClose();
            }
        }

        private void EditorFrame_Load(object sender, System.EventArgs e)
        {
            this.Text = $"{Text} - {PluginCommandStub.Commands.GetEffectName()}";

            if (PluginCommandStub.Commands.EditorGetRect(out Rectangle wndRect))
            {
                panel1.Size = wndRect.Size;
                wndRect.Inflate(10, 10);
                this.Size = this.SizeFromClientSize(wndRect.Size);
                PluginCommandStub.Commands.EditorOpen(panel1.Handle);
            }
        }
    }
}
