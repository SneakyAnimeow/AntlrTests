// See https://aka.ms/new-console-template for more information

// AntlrTests.TinyC.Program.Main();
// AntlrTests.MyTinyC.Program.Main();
// AntlrTests.NekoScript.Program.Main();
AntlrTests.OwOLang.Program.Main();

// using System.Dynamic;
// using AntlrTests.OwOLang;

// var obj = new OwODynamicObject();
//
// obj.TrySetMember(new SetMemberBinder("Name", false), "Mittens");

// var type = Type.GetType("System.Int32");
//
// dynamic list = Activator.CreateInstance(typeof(List<>).MakeGenericType(type));

// using System.Dynamic;
// using System.Reflection;
// using AntlrTests.OwOLang;
// using Newtonsoft.Json;
//
// var type = SimpleOwOLangVisitor.CreateNewType("Cat");
//
// Console.WriteLine(type.GetTypeInfo());
//
// var fromType = (dynamic) Activator.CreateInstance(type);
//
// // get the type we just created during runtime
//
// var catType = Type.GetType("Cat");
// //
// // Console.WriteLine(catType);
//
// // create a new instance of the type
//
// // dynamic cat = Activator.CreateInstance(catType);
//
// dynamic cat = Activator.CreateInstance(catType);
//
// cat.Name = "Mittens";
//
// Console.WriteLine(JsonConvert.SerializeObject(cat));

// public static Type CreateNewType(string name) {
//     //Create new C# type
//     var typeBuilder = AssemblyBuilder
//         .DefineDynamicAssembly(new AssemblyName("OwOLangDynamics"), AssemblyBuilderAccess.Run)
//         .DefineDynamicModule("OwOLangDynamics")
//         .DefineType(name, TypeAttributes.Public);
//
//     //inherit from ExpandoObject
//     typeBuilder.SetParent(typeof(DynamicObject));
//
//     //create type
//     var type = typeBuilder.CreateType();
//
//     return type;
// }