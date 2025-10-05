namespace SharpMetal.Generator.Linked
{
    public class CSharpEnumType : CSharpType
    {
        public CSharpEnumType(string name) : base(TypeKind.Enum, name)
        {
        }

        public void SetPrimitiveType(string type)
        {
            BaseTypes.Clear();
            BaseTypes.Add(type);
        }

        public void MarkAsFlags()
        {
            Attributes.Add("[Flags]");
        }
    }
}
