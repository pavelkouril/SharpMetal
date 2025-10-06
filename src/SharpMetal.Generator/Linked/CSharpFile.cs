namespace SharpMetal.Generator.Linked
{
    public class CSharpFile : ICodeFragmentProvider
    {
        public List<CSharpNamespace> Namespaces { get; private set; }

        public string Name;

        public string Directory;

        public string FilePath;

        private List<string> _usings = [];

        public CSharpFile(string name, string directory)
        {
            Name = name;
            Directory = directory;
            FilePath = $"{directory}/{name}.cs";
            Namespaces = [];
        }

        public CSharpNamespace GetOrCreateNamespace(string @namespace)
        {
            foreach (var ns in Namespaces)
            {
                if (ns.Name == @namespace)
                {
                    return ns;
                }
            }

            var rv = new CSharpNamespace(@namespace);
            Namespaces.Add(rv);
            return rv;
        }

        public void Generate(CodeGenContext context)
        {
            if (_usings.Count > 0)
            {
                foreach (var @using in _usings)
                {
                    context.WriteLine($"using {@using};");
                }
                context.WriteLine();
            }

            foreach (var ns in Namespaces)
            {
                context.WriteLine($"namespace {ns.Name}");
                context.EnterScope();

                foreach (var type in ns.Types)
                {
                    type.Generate(context);
                }

                context.LeaveScope();
            }
        }

        public void AddUsing(string @namespace)
        {
            _usings.Add(@namespace);
        }
    }
}
