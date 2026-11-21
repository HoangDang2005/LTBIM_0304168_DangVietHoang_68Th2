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
            //Chọn các cạnh và in ra các cạnh đó
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            IList<Reference> referencesCollection = uidoc.Selection.PickObjects(ObjectType.Edge);
            MessageBox.Show("Ban da chon tong tat ca" + referencesCollection.Count.ToString() + "edge");

            return Result.Succeeded;

        }

    }
}



