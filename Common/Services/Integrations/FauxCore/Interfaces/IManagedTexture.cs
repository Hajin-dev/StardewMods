namespace StardewMods.Common.Services.Integrations.FauxCore;

using Microsoft.Xna.Framework.Graphics;

/// <summary>Represents a texture managed by <see cref="IThemeHelper" />.</summary>
public interface IManagedTexture
{
    /// <summary>Gets the asset name of the managed texture.</summary>
    public IAssetName Name { get; }

    /// <summary>Gets the current texture for the managed asset.</summary>
    public Texture2D Value { get; }
}