using HYDbklgn.Framework.metadata;
using System.ComponentModel.DataAnnotations;
using HYDbklgn.Abstraction;
using System.ComponentModel.DataAnnotations.Schema;

namespace HYDbklgn.Framework
{


    [MetadataType(typeof(SettingEdit_MetaData))]
    public partial class CoreSetting: IEditSettingModel
    {

    }



}
