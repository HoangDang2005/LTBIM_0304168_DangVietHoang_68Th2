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

namespace TESTrevit2025
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Class1 : IExternalCommand
    {
        private Document document;

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //MessageBox.Show("Hello world");
            //for(int i=0;i<6;i++)
            //{
            //    MessageBox.Show(i.ToString());  6/11
            //}
            //MessageBox.Show("check");


            //10/11/2026(1)
            //UIDocument uidoc = commandData.Application.ActiveUIDocument;
            //ICollection<ElementId> SelectElement = uidoc.Selection.GetElementIds();
            //int totaCount = SelectElement.Count;
            //MessageBox.Show("Ban da chon" + totaCount.ToString() + "element");
            ////phat trien code
            //string IDList = "Danh sach ID cua doi tuong:\n";
            //foreach (ElementId e1 in SelectElement)
            //{
            //    IDList = IDList + e1.ToString() + "\n";
            //}
            //MessageBox.Show(IDList);



            //10/11/2026(1)

            //chọn các điểm và in ra tọa độ các điểm đó
            //UIDocument uidoc = commandData.Application.ActiveUIDocument;
            //XYZ point1 = uidoc.Selection.PickPoint();
            //XYZ point2 = uidoc.Selection.PickPoint();
            //XYZ point3 = uidoc.Selection.PickPoint();

            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine(point1.ToString());
            //sb.AppendLine(point2.ToString());
            //sb.AppendLine(point3.ToString());

            //MessageBox.Show("Ban da lua chon cac diem points:\n" + sb.ToString());

            //10/11/2026(3)
            //Chọn các cạnh và in ra các cạnh đó
            //UIDocument uidoc = commandData.Application.ActiveUIDocument;
            //IList<Reference> referencesCollection = uidoc.Selection.PickObjects(ObjectType.Edge);
            //MessageBox.Show("Ban da chon tong tat ca " + referencesCollection.Count.ToString() + " edge");


            //10/11/2026(4)
            ////select các mặt phẳng
            //UIDocument uidoc = commandData.Application.ActiveUIDocument; //lấy file revit đang hiện hành
            //XYZ point1 = uidoc.Selection.PickPoint();
            //XYZ point2 = uidoc.Selection.PickPoint();
            //XYZ point4 = uidoc.Selection.PickPoint();
            //if (point1.X == point2.X && point1.Y == point4.Y && point1.Z == point4.Z)
            //{
            //    MessageBox.Show("abcxyz");
            //}

            ////MessageBox.Show("abcxyz");

            //17/11/2026
            //vd1: selection and filter
            //UIDocument uidoc = commandData.Application.ActiveUIDocument;
            //ICollection<ElementId> selectedIds = uidoc.Selection.GetElementIds();
            //Autodesk.Revit.UI.TaskDialog.Show("Revit", "Số lượng đối tượng được chọn: " + selectedIds.Count.ToString());
            //ICollection<ElementId> selectedWallIds = new List<ElementId>();
            //ICollection<ElementId> SelectedFloor = new List<ElementId>();
            //ICollection<ElementId> SelectedColumn = new List<ElementId>();
            //FilteredElementCollector collector = new FilteredElementCollector(document);
            //ICollection<Element> elementsColumns = collector.OfClass(typeof(FamilyInstance)).OfCategory(BuiltInCategory.OST_StructuralColumns).ToElements();
            //foreach (ElementId id in selectedIds)
            //{
            //    Element elements1 = uidoc.Document.GetElement(id);
            //    if (elements1 is Wall)
            //    {
            //        selectedWallIds.Add(id);
            //    }
            //}
            //// Set the created element set as current select element set.
            //uidoc.Selection.SetElementIds(selectedWallIds);
            //if (0 != selectedWallIds.Count)
            //{
            //    Autodesk.Revit.UI.TaskDialog.Show("Revit", selectedWallIds.Count.ToString() + " Đối tượng Tường đã được chọn!");
            //}
            //else
            //{
            //    Autodesk.Revit.UI.TaskDialog.Show("Revit", "Không có đối tượng tường nào được chọn!");

            //}




            //17/11/2026

            //Document doc = commandData.Application.ActiveUIDocument.Document;
            //FilteredElementCollector collector = new FilteredElementCollector(doc);
            //ElementCategoryFilter filter = new ElementCategoryFilter(BuiltInCategory.OST_Materials);
            //IList<Element> matList = collector.WherePasses(filter).WhereElementIsNotElementType().ToElements();
            //StringBuilder result = new StringBuilder();
            //foreach (Element ele in matList)
            //{
            //    result.AppendLine(ele.Category.Name + "\t" + ele.Name + "\t" + ele.Id);
            //}
            //MessageBox.Show("Tất cả các materials trong project là:\r\n" + result.ToString());


            //20/11/2026-1
            //    UIDocument uidoc = commandData.Application.ActiveUIDocument;
            //    Document doc = uidoc.Document;
            //    FilteredElementCollector collector = new FilteredElementCollector(doc);
            //    ElementCategoryFilter filter = new ElementCategoryFilter(BuiltInCategory.OST_StructuralFraming);

            //    IList<Element> wallList = collector.WherePasses(filter).WhereElementIsNotElementType().ToElements();

            //    StringBuilder sb = new StringBuilder();
            //    foreach (Element wall in wallList) //for each wall
            //    {
            //        sb.AppendLine(wall.Name + "::" + wall.Id);
            //        foreach (Parameter para in wall.Parameters) //for each parameter
            //        {
            //            sb.Append(this.getParameterInfomation(para, doc, ":")); //print parameter information
            //            sb.AppendLine();
            //        }
            //        sb.AppendLine();
            //    }
            //    MessageBox.Show(sb.ToString());
            //    return Result.Succeeded;
            //}
            //private string getParameterInfomation(Parameter para, Document doc, string seperator)
            //{
            //    string defName = para.Definition.Name;
            //switch (para.StorageType)
            //    {
            //        case StorageType.Double: //if the parameter is a double, use AsValueString() to return the value
            //            return defName + seperator + para.AsValueString();
            //        case StorageType.ElementId:
            //            //if the parameter is a element id, its IntegerValue would be either a positive integer or -1
            //            //-1 means an invalid element id
            //            ElementId id = para.AsElementId();
            //            if (id.IntegerValue >= 0) //if IntegerValue is not -1, we can get the parameter by Element.Name
            //                return defName + seperator + doc.GetElement(id).Name;
            //            else //if IntegerValue is -1, print -1 because it is an invalid ElementId
            //                return defName + seperator + id.IntegerValue.ToString();
            //        case StorageType.Integer: //if the parameter is an integer, it would be a boolean or an integer
            //            if (para.Definition.GetDataType()==SpecTypeId.Boolean.YesNo)//if it is a boolean (0 or 1)
            //            {
            //                //we must use true or false to represent the parameter instead of 0 or 1
            //                if (para.AsInteger() == 0)
            //                    return defName + seperator + "False";
            //                else //para.AsInteger() == 1
            //                    return defName + seperator + "True";
            //            }
            //            else //if it is an integer, just use AsInteger().ToString() to get the string value
            //            {
            //                return defName + seperator + para.AsInteger().ToString();
            //            }
            //        case StorageType.String: //if it is a string, we can return it by AsString()
            //            return defName + seperator + para.AsString();
            //        default:
            //            return "unknown parameter";
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            //ElementCategoryFilter filter = new ElementCategoryFilter(BuiltInCategory.OST_StructuralColumns);
            ElementCategoryFilter filter = new ElementCategoryFilter(BuiltInCategory.OST_Walls);

            IList<Element> columnList = collector.WherePasses(filter).WhereElementIsNotElementType().ToElements();
            //StringBuilder output = new StringBuilder("Tất cả các Structural Column trong BIM model :"+columnList.Count()+"\r\n");
            StringBuilder output = new StringBuilder("Tất cả các Walls trong BIM model :" + columnList.Count() + "\r\n");

            foreach (Element e1 in columnList)
            {
                string elemName = e1.Id.ToString() + "\n";
                ElementType type = doc.GetElement(e1.GetTypeId()) as ElementType;
                AnalyticalMember analyticalMember =doc.GetElement(e1.Id) as AnalyticalMember;
                double hh1 = ChangeUnitFeetToMillimeter(h1.AsDouble());
                //Parameter b = type.LookupParameter("b");
                //double bb1 = ChangeUnitFeetToMillimeter(b.AsDouble());
                elemName = elemName + "Width = " + hh1.ToString() + "\n";
                //elemName = elemName + "b = " + bb1.ToString() + "\n";
                output.Append(elemName);
                output.AppendLine();
            }
            MessageBox.Show(output.ToString());
            return Result.Succeeded;
        }
        static double ChangeUnitFeetToMillimeter(double Value)
        {
            double value;
            value = Math.Round(UnitUtils.Convert(Value, DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_MILLIMETERS), 2);
            return value;
        }
        }
    }



