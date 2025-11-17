using System.Globalization;
using System.Text;

namespace TP11_EDD2.DATA.Entities;

/// <summary>
/// Represents an access log entry, recording the user, authorization status, and the UTC timestamp.
/// </summary>
/// <remarks>
/// PT-BR: Representa uma entrada de log de acesso, registrando o usuário, status de autorização e o carimbo de data/hora em UTC.
/// </remarks>
public class Log
{
    /// <summary>
    /// The date and time of the access attempt in Coordinated Universal Time (UTC).
    /// </summary>
    /// <remarks>
    /// PT-BR: A data e hora da tentativa de acesso no Tempo Universal Coordenado (UTC).
    /// </remarks>
    public DateTime AccessDate { get; set; }

    /// <summary>
    /// The user who attempted the access.
    /// </summary>
    /// <remarks>
    /// PT-BR: O usuário que tentou o acesso.
    /// </remarks>
    public User User { get; set; }

    /// <summary>
    /// Indicates whether the access was authorized or denied.
    /// </summary>
    /// <remarks>
    /// PT-BR: Indica se o acesso foi autorizado ou negado.
    /// </remarks>
    public bool IsAuthorized { get; set; }

    /// <summary>
    /// Static read-only CultureInfo set to Brazilian Portuguese (pt-BR) for formatting dates and numbers.
    /// </summary>
    /// <remarks>
    /// PT-BR: CultureInfo estático e somente leitura configurado para Português do Brasil (pt-BR) para formatação de datas e números.
    /// </remarks>
    private static readonly CultureInfo PtBrCulture = new CultureInfo("pt-BR");

    /// <summary>
    /// Initializes a new instance of the Log class using the current UTC time.
    /// </summary>
    /// <param name="user">The user attempting access.</param>
    /// <param name="isAuthorized">Whether the access is allowed.</param>
    /// <remarks>
    /// PT-BR: Inicializa uma nova instância da classe Log usando o horário UTC atual.
    /// </remarks>
    public Log(User user, bool isAuthorized)
    {
        AccessDate = DateTime.UtcNow;
        User = user;
        IsAuthorized = isAuthorized;
    }

    /// <summary>
    /// Returns a string representation of the log, converting the UTC time to Brasília time and formatting it in pt-BR.
    /// </summary>
    /// <returns>A formatted string with date, time, user name, and status.</returns>
    /// <remarks>
    /// PT-BR: Retorna uma representação em string do log, convertendo o horário UTC para o horário de Brasília e formatando em pt-BR.
    /// </remarks>
    public override string ToString()
    {
        var brazilTimeZone = TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo");
        var localTime = TimeZoneInfo.ConvertTimeFromUtc(AccessDate, brazilTimeZone);

        // 2. Formatar usando a cultura pt-BR explicitamente
        string date = localTime.ToString("d", PtBrCulture);
        string hour = localTime.ToString("t", PtBrCulture);

        return $"{date} - {hour} = {User.Name}  - {(IsAuthorized ? "Autorizado" : "Não Autorizado")}";
    }
}