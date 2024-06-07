namespace ApiUsuariosUeceMy.Domain.Execption;

[Serializable]
public class AppUsuarioUceMyValidatorException : Exception
{
    public AppUsuarioUceMyValidatorException(Dictionary<string, IEnumerable<string>> errors) : base("Invalid data")
        => Errors = errors;

    public Dictionary<string, IEnumerable<string>> Errors { get; }
}
