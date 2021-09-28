using EPiServer.Shell;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using System;
using System.Web.ModelBinding;

namespace AlloyTraining.Business.EditorDescriptors
{

    [EditorDescriptorRegistration(TargetType = typeof(String), UIHint = "AutoSuggest")]
    public class FontAwesomeSelectionAttribute : EditorDescriptor
    {
        public FontAwesomeSelectionAttribute()
        {
            ClientEditingClass = "geta-epi-cms.editors.FontAwesomeAutoSuggestEditor";
        }
    }
}