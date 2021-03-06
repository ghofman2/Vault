﻿using System;
using Vault.Data.ViewModels.Base;

namespace Vault.Data.ViewModels
{
  public class FolderModel : EntityModel
  {
    public string Name { get; set; }

    public int CabinetId { get; set; }

    public CabinetModel Cabinet { get; set; }

    public String Extension { get; set; }

    public DateTime DeletedDate { get; set; }

    public DateTime CreationDate { get; set; }

    public int Pages { get; set; }
  }
}
