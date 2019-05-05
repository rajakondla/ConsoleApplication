using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    enum enumTypes { Number,Varchar,Generic };

    struct Types
    {
        public static Type GetType(enumTypes type)
        {
            switch (type)
            {
                case enumTypes.Number : return typeof(int);
                case enumTypes.Varchar: return typeof(string);
                case enumTypes.Generic: return typeof(object);
                default: return typeof(int);
            }
        }
    }

    class ReferenceCheck
    {
        static void Main()
        {
            QueryTemplate query = new EmployeeQuery();
            string generatedQuery = query.GenerateQuery();
            Console.WriteLine(generatedQuery);
          
            Console.ReadLine();
        }
    }

    class EmployeeQuery : QueryTemplate
    {
        protected override Query Select()
        {
            Field field = new Field("Name", Types.GetType(enumTypes.Generic), new AggregateField { FunctionName="Count" });
            Field field2 = new Field("Salary", Types.GetType(enumTypes.Generic), new AggregateField { FunctionName="Sum" });

            var dynamicClass = new DynamicClass().CreateDynamicObject(new List<Field> { field, field2 });
            Query selectObj = new SelectQuery(dynamicClass, "Employee ");
            return selectObj;
        }

        protected override Query Where()
        {
            Field field = new Field("Name", Types.GetType(enumTypes.Varchar), "Raja Kondla");
          //  Field field2 = new Field("Salary", Types.GetType("number"), 0);

            var dynamicClass = new DynamicClass().CreateDynamicObject(new List<Field> { field, });
            Query selectObj = new WhereQuery(dynamicClass);
            return selectObj;
        }
    }
    
    public abstract class Query
    {
        public Query(object obj)
        {

        }

        public abstract string GenerateQuery();
    }

    abstract class QueryTemplate
    {
        private NoQuery noQueryObj;

        public QueryTemplate()
        {
            List<Field> fields = new List<Field> { new Field("NoName", typeof(string), "") };
            object classObj = new DynamicClass().CreateDynamicObject(fields);
            noQueryObj = new NoQuery(classObj);
        }

        protected abstract Query Select();

        protected virtual Query Where()
        {
            return noQueryObj;
        }

        protected virtual Query GroupBy()
        {
            return noQueryObj;
        }

        protected virtual Query Having()
        {
            return noQueryObj;
        }

        protected virtual Query OrderBy()
        {
            return noQueryObj;
        }

        public string GenerateQuery()
        {
            return Select().GenerateQuery() + Where().GenerateQuery() + GroupBy().GenerateQuery() + Having().GenerateQuery() + OrderBy().GenerateQuery();
        }
    }

    class NoQuery : Query
    {
        object _dObj;
        public NoQuery(object dObj)
           : base(dObj)
        {
            _dObj = dObj;
        }

        public override string GenerateQuery()
        {
            return string.Empty;
        }
    }

    class StringBuilderHelper
    {
        StringBuilder _sb = new StringBuilder();

        public StringBuilderHelper(string appendStr)
        {
            _sb.Append(appendStr);
        }

        public StringBuilder StringBuilder
        {
            get => _sb;
        }

        public StringBuilderHelper Append(string appendStr)
        {
            _sb.Append(appendStr);
            return this;
        }

        public static StringBuilderHelper operator ==(StringBuilderHelper sb, string str)
        {
            return sb.Append("=" + str);
        }

        public static StringBuilderHelper operator !=(StringBuilderHelper sb, string str)
        {
            return sb.Append("!=" + str );
        }

        public static StringBuilderHelper operator >(StringBuilderHelper sb, string str)
        {
            return sb.Append(">" + str);
        }

        public static StringBuilderHelper operator <(StringBuilderHelper sb, string str)
        {
            return sb.Append("<" + str);
        }

        public static StringBuilderHelper operator >=(StringBuilderHelper sb, string str)
        {
            return sb.Append(">=" + str);
        }

        public static StringBuilderHelper operator <=(StringBuilderHelper sb, string str)
        {
            return sb.Append("<=" + str);
        }

        public static StringBuilderHelper operator |(StringBuilderHelper sb, string str)
        {
            return sb.Append("or  ");
        }

        public static StringBuilderHelper operator &(StringBuilderHelper sb, string str)
        {
            return sb.Append("and ");
        }

        public override string ToString()
        {
            return _sb.Remove(_sb.Length - 4, 4).ToString();
        }
    }

    public class SelectQuery : Query
    {
        object _dObj;
        StringBuilder _builder = new StringBuilder("Select ");
        string _tableName = string.Empty;

        public SelectQuery(object dObj, string tableName)
            : base(dObj)
        {
            _dObj = dObj;
            _tableName = tableName;
        }

        public override string GenerateQuery()
        {
            foreach (PropertyInfo get in _dObj.GetType().GetProperties())
            {
                object value = get.GetValue(_dObj);
                if (value is AggregateField)
                    _builder.Append(((AggregateField)value).FunctionName).Append("(").Append(get.Name).Append("),");
                else
                    _builder.Append(get.Name).Append(",");
            }
            return _builder.Remove(_builder.Length - 1, 1).Append(" From " + _tableName).ToString();
        }
    }

    public class WhereQuery : Query
    {
        object _dObj;
        StringBuilderHelper _builder = new StringBuilderHelper("Where ");

        public WhereQuery(object dObj)
            : base(dObj)
        {
            _dObj = dObj;
        }

        public override string GenerateQuery()
        {
            foreach (PropertyInfo get in _dObj.GetType().GetProperties())
            {
                _builder = _builder.Append(get.Name) == (string)(get.GetType().IsValueType ? get.GetValue(_dObj) : "'" + get.GetValue(_dObj) + "'");
                _builder = _builder & "";
            }
            return _builder.ToString();
        }
    }

    public class Field
    {
        private string _fieldName;
        private Type _fieldType;
        private object _value;

        public Field(string fieldName, Type fieldType, object value)
        {
            _fieldName = fieldName;
            _fieldType = fieldType;
            _value = value;
        }

        public string FieldName
        {
            get { return _fieldName; }
        }

        public Type FieldType
        {
            get { return _fieldType; }
        }

        public object Value
        {
            get { return _value; }
        }
    }

    struct AggregateField
    {
        public string FunctionName { get; set; }
    }

    //public class DynamicClass : DynamicObject
    //{
    //    private Dictionary<string, KeyValuePair<Type, object>> _fields;

    //    public DynamicClass(List<Field> fields)
    //    {
    //        _fields = new Dictionary<string, KeyValuePair<Type, object>>();
    //        fields.ForEach(x => _fields.Add(x.FieldName,
    //            new KeyValuePair<Type, object>(x.FieldType, x.Value)));
    //    }

    //    public override bool TrySetMember(SetMemberBinder binder, object value)
    //    {
    //        if (_fields.ContainsKey(binder.Name))
    //        {
    //            var type = _fields[binder.Name].Key;
    //            if (value.GetType() == type)
    //            {
    //                _fields[binder.Name] = new KeyValuePair<Type, object>(type, value);
    //                return true;
    //            }
    //            else throw new Exception("Value " + value + " is not of type " + type.Name);
    //        }
    //        return false;
    //    }

    //    public override bool TryGetMember(GetMemberBinder binder, out object result)
    //    {
    //        result = _fields[binder.Name].Value;
    //        return true;
    //    }
    //}

    public class DynamicClass
    {
        AssemblyName assemblyName = null;
        AssemblyBuilder assemblyBuilder = null;
        TypeBuilder typeBuilder = null;

        public DynamicClass()
        {
            assemblyName = new AssemblyName("DynamicClass");
            assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
        }

        public object CreateDynamicObject(List<Field> fields)
        {
            typeBuilder = this.CreateClass();
            this.CreateConstructor(typeBuilder);
            foreach (Field field in fields)
                CreateProperty(typeBuilder, field.FieldName, field.FieldType, field.Value);
            Type type = typeBuilder.CreateType();
            object obj = Activator.CreateInstance(type);
            foreach (Field field in fields)
            {
                foreach (PropertyInfo property in obj.GetType().GetProperties())
                {
                    if (field.FieldName == property.Name)
                        property.SetValue(obj, field.Value);
                }
            }
            return obj;
        }

        private TypeBuilder CreateClass()
        {
            TypeBuilder typeBuilder = assemblyBuilder.DefineDynamicModule("MainModule").DefineType(this.assemblyName.FullName
                              , TypeAttributes.Public |
                              TypeAttributes.Class |
                              TypeAttributes.AutoClass |
                              TypeAttributes.AnsiClass |
                              TypeAttributes.BeforeFieldInit |
                              TypeAttributes.AutoLayout
                              , null);
            return typeBuilder;
        }

        private void CreateConstructor(TypeBuilder typeBuilder)
        {
            typeBuilder.DefineDefaultConstructor(MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
        }

        private void CreateProperty(TypeBuilder typeBuilder, string propertyName, Type propertyType, object value)
        {
            FieldBuilder fieldBuilder = typeBuilder.DefineField("_" + propertyName, propertyType, FieldAttributes.Private);

            PropertyBuilder propertyBuilder = typeBuilder.DefineProperty(propertyName, PropertyAttributes.HasDefault, propertyType, null);
            MethodBuilder getPropMthdBldr = typeBuilder.DefineMethod("get_" + propertyName, MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig, propertyType, Type.EmptyTypes);
            ILGenerator getIl = getPropMthdBldr.GetILGenerator();

            getIl.Emit(OpCodes.Ldarg_0);
            getIl.Emit(OpCodes.Ldfld, fieldBuilder);
            getIl.Emit(OpCodes.Ret);

            MethodBuilder setPropMthdBldr = typeBuilder.DefineMethod("set_" + propertyName,
                  MethodAttributes.Public |
                  MethodAttributes.SpecialName |
                  MethodAttributes.HideBySig,
                  null, new[] { propertyType });

            ILGenerator setIl = setPropMthdBldr.GetILGenerator();
            Label modifyProperty = setIl.DefineLabel();
            Label exitSet = setIl.DefineLabel();

            setIl.MarkLabel(modifyProperty);
            setIl.Emit(OpCodes.Ldarg_0);
            setIl.Emit(OpCodes.Ldarg_1);
            setIl.Emit(OpCodes.Stfld, fieldBuilder);

            setIl.Emit(OpCodes.Nop);
            setIl.MarkLabel(exitSet);
            setIl.Emit(OpCodes.Ret);

            propertyBuilder.SetGetMethod(getPropMthdBldr);
            propertyBuilder.SetSetMethod(setPropMthdBldr);
        }
    }
}
