using EPPlus.Core.Extensions;
using KeToanDTO;
using OfficeOpenXml;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ToolKeToanConvertWindowsForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            ReadDataTonDau();
        }

        private void ReadDataTonDau()
        {
            string path = "D://so lieu ton kho.xlsx";
            FileInfo fileInfo = new FileInfo(path);

            ExcelPackage package = new ExcelPackage(fileInfo);
            // Direct usage: 
            package.ToList<SoLieuTonKhoDto>(1, configuration => configuration.SkipCastingErrors());
            // Specific worksheet: 
            var soLieuTonDau = package.GetWorksheet(1).ToList<SoLieuTonKhoDto>();
        }
    }
}
