using System.Dynamic;

namespace AntlrTests.OwOLang; 

public class OwODynamicObject : DynamicObject {
    private readonly Dictionary<string, object> _properties = new();

    public override bool TryGetMember(GetMemberBinder binder, out object result) {
        var name = binder.Name.ToLower();

        return _properties.TryGetValue(name, out result);
    }

    public override bool TrySetMember(SetMemberBinder binder, object value) {
        var name = binder.Name.ToLower();

        _properties[name] = value;

        return true;
    }

    public override IEnumerable<string> GetDynamicMemberNames() {
        return _properties.Keys;
    }
}