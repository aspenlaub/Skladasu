using System.Collections.Generic;
using System.Linq;
using Aspenlaub.Net.GitHub.CSharp.Skladasu.Extensions;
using Aspenlaub.Net.GitHub.CSharp.Skladasu.Interfaces;

// ReSharper disable UnusedMember.Global

namespace Aspenlaub.Net.GitHub.CSharp.Skladasu.Entities;

public class ErrorsAndInfos : IErrorsAndInfos {
    public IList<string> Errors { get; } = new List<string>();
    public IList<string> Infos { get; } = new List<string>();

    public bool AnyErrors() {
        return Errors.Any();
    }

    public bool AnyInfos() {
        return Infos.Any();
    }

    public override string ToString() {
        return this.ErrorsToString();
    }
}