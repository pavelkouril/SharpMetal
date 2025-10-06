namespace SharpMetal.Generator.Linked
{
    public class CSharpField : CSharpTypeMember
    {
        public string? DefaultValue { get; set; }

        public CSharpField(string name): base(name, MemberKind.Field)
        {
        }

        public override void Generate(CodeGenContext context)
        {

        }
    }
}
