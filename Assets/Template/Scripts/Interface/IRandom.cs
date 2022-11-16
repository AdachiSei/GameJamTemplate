
/// <summary>
/// SerializableやScriptableObjectに継承させてください
/// </summary>
/// <typeparam name="TScriptName">Scriptの名前</typeparam>
/// <typeparam name="T">値型</typeparam>
public interface IRandom<TScriptName, T>
{
    public T[] AllValue(TScriptName[] num);
    //return num.Select(e => e.T型).ToArray();
}

public interface IRandomList<TScriptName, T>
{
    public T[] AllValue(TScriptName num);
    //return num.T型.ToArray();
}
