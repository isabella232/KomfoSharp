﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDescriptionCalling.cs" company="Sitecore A/S">
//  Copyright (C) 2015 by Sitecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace KomfoSharp.Sessions.Authenticated.Requests.Ads.Fluent
{
  /// <summary>
  /// Defines the call to specify the description.
  /// </summary>
  /// <typeparam name="T">The result of the call.</typeparam>
  public interface IDescriptionCalling<out T>
  {
    /// <summary>
    /// Specifies the description.
    /// </summary>
    /// <param name="description">The description.</param>
    /// <returns>The result of the call.</returns>
    T Description(string description);
  }
}