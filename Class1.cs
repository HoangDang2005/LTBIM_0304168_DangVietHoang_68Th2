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
            //select các mặt phẳng 
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            XYZ point1 = uidoc.Selection.PickPoint();
            XYZ point2 = uidoc.Selection.PickPoint();
            XYZ point4 = uidoc.Selection.PickPoint();
            if (point1.X == point2.X && point1.Y == point4.Y && point1.Z == point4.Z)
            {
                MessageBox.Show("");
            }

            return Result.Succeeded;

        }

    }
}



