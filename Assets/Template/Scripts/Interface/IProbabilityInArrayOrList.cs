
/// <summary>
/// SerializableやScriptableObjectに継承させてください
/// </summary>
/// <typeparam name="TScriptName">Scriptの名前</typeparam>
/// <typeparam name="T">値型</typeparam>
public interface IProbabilityInArrayOrList<TScriptName, T>
    where T : struct
    where TScriptName : IProbabilityInArrayOrList<TScriptName, T>
{
    public T[] AllValue(TScriptName num);
    //return num.T型.ToArray();
}
