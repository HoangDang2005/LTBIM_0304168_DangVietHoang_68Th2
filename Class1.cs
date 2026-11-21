using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Structure;

namespace Revit2025

{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Class1 : IExternalCommand
    {
        private Document document;

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            ICollection<ElementId> SelectElement = uidoc.Selection.GetElementIds();
            int totaCount = SelectElement.Count;
            MessageBox.Show("Ban da chon" + totaCount.ToString() + "element");
            //phat trien code
            string IDList = "Danh sach ID cua doi tuong:\n";
            foreach (ElementId e1 in SelectElement)
            {
                IDList = IDList + e1.ToString() + "\n";
            }
            MessageBox.Show(IDList);

            return Result.Succeeded;

        }

    }
}



