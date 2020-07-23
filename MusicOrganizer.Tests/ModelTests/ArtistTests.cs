using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using MusicOrganizer.Models;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class ArtistTest : IDisposable
  {
    public void Dispose()
    {
      Artist.ClearAll();
    }
    
    [TestMethod]
    public void ArtistConstructor_CanCreateAlbumObject_MatchType()
    {
      Artist newArtist = new Artist("Paul Simon");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
      Assert.AreEqual("Paul Simon", newArtist.ArtistName);
    }

    [TestMethod]
    public void ArtistList_ArtistsAreAddedToList_ListAdd()
    {
      Artist newArtist = new Artist("Radiohead");
      List<Artist> expectedList = new List<Artist> { newArtist };
      CollectionAssert.AreEqual(expectedList, Artist.GetAll());
    }
  }
}