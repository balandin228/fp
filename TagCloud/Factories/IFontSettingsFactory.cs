﻿using TagCloud.Models;

namespace TagCloud.IServices
{
    public interface IFontSettingsFactory
    {
        FontSettings CreateFontSettingsOrThrow(string fontName);
    }
}