using SistemaEducativo.Models;
using SistemaEducativo.Properties;
using SistemaEducativo.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers
{
    internal class TareaPreviewController
    {
        private FrmTareaPreview _frmTareaPreview;
        private TareaPorAlumno tareaSeleccionado;

        public TareaPreviewController(FrmTareaPreview frmTareaPreview, TareaPorAlumno tarea)
        {
            _frmTareaPreview = frmTareaPreview;
            tareaSeleccionado = tarea;

            _frmTareaPreview.Load += frmTareaPreview_Load;
            _frmTareaPreview.btnVerArchivo.Click += btnVerArchivo_Click;
        }

        private void frmTareaPreview_Load(object sender, EventArgs e)
        {
            _frmTareaPreview.lblExtension.Text = Path.GetExtension(tareaSeleccionado.PathArchivoTarea);
            FileInfo fileInfo = new FileInfo(tareaSeleccionado.PathArchivoTarea);

            if (fileInfo.Length < 1000)
            {
                _frmTareaPreview.lblPeso.Text = $"{fileInfo.Length} Bytes";
            }
            else if (fileInfo.Length >= 1000 && fileInfo.Length < 1000000)
            {
                double kiloBytes = fileInfo.Length / 1000;
                _frmTareaPreview.lblPeso.Text = $"{kiloBytes} Kb";
            } else if (fileInfo.Length >= 1000000 && fileInfo.Length < 1000000000)
            {
                double megaBytes = fileInfo.Length / 1000000;
                _frmTareaPreview.lblPeso.Text = $"{megaBytes} Mb";
            } else
            {
                double gigaBytes = fileInfo.Length / 1000000;
                _frmTareaPreview.lblPeso.Text = $"{gigaBytes} Gb";
            }

            switch (fileInfo.Extension)
            {
                case ".pdf":
                    _frmTareaPreview.pictureBoxFileIcon.Image = Resources.pdfIcon;
                    break;
                case ".jpg":
                case ".png":
                    _frmTareaPreview.pictureBoxFileIcon.Image = Resources.imagenIcon;
                    break;
            }
        }

        private void btnVerArchivo_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = tareaSeleccionado.PathArchivoTarea
            });
        }
    }
}
