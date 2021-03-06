﻿using System.Collections.Generic;
using Vault.Data.Models;
using Vault.Data.ViewModels.Base;

namespace Vault.Data.ViewModels
{
  public class CabinetModel : EntityModel
  {
    public string Name { get; set; }

    public ICollection<FolderModel> Folders { get; set; }

    public ICollection<CustomField> CustomFields { get; set; }
  }
}
