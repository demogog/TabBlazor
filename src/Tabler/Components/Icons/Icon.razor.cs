﻿using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Tabler.Components
{
    public partial class Icon : TablerBaseComponent
    {
     //   [Parameter(CaptureUnmatchedValues = true)] public Dictionary<string, object> Attributes { get; set; }
        [Parameter] public string Color { get; set; }
        [Parameter] public int Size { get; set; } = 24;
        [Parameter] public double StrokeWidth { get; set; } = 2;
        [Parameter] public string Elements { get; set; }
      //  [Parameter] public TablerColor? TablerColor { get; set; }


        protected override string ClassNames => ClassBuilder
             .AddIf($"{TextColor.GetColorClass("text")}", string.IsNullOrWhiteSpace(Color))
            .ToString();
    }
}
