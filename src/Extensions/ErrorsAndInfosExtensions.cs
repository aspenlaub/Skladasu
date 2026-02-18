using Aspenlaub.Net.GitHub.CSharp.Skladasu.Interfaces;

// ReSharper disable UnusedMember.Global

namespace Aspenlaub.Net.GitHub.CSharp.Skladasu.Extensions;

public static class ErrorsAndInfosExtensions {
    public static string ErrorsToString(this IErrorsAndInfos errorsAndInfos) {
        return string.Join("\r\n", errorsAndInfos.Errors);
    }
}