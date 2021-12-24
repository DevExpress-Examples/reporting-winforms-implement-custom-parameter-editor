using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.Parameters;

namespace WindowsFormsApp1 {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void XtraReport1_ParametersRequestBeforeShow(object sender, ParametersRequestEventArgs e) {
            // Create and set up a radio group editor.
            var radioGroup = CreateRadioGroup();

            // Find a required parameter by name and assign
            // a custom editor to the Editor property.
            foreach (var info in e.ParametersInformation) {
                if (info.Parameter.Name == "shape") {
                    info.Editor = radioGroup;
                    break;
                }
            }
        }

        private RadioGroup CreateRadioGroup() {
            var radioGroup = new RadioGroup();

            string[] radioGroupItemTitles = new string[] {
                "Circle", "Rectangle", "Ellipse",
                "Triangle", "Square"
            };

            foreach (var item in radioGroupItemTitles) {
                radioGroup.Properties.Items.Add(new RadioGroupItem(item, item));
            }

            radioGroup.Properties.ItemVertAlignment = RadioItemVertAlignment.Top;
            radioGroup.MinimumSize = new System.Drawing.Size(0, 100);

            return radioGroup;
        }
    }
}
