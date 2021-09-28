using System;
using System.Collections.Generic;
using System.Web;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace EPiServer.Templates.Alloy.Business.EditorDescriptors
{
    [EditorDescriptorRegistration(TargetType = typeof(string), UIHint = "author")]
    public class EditorSelectionEditorDescriptor : EditorDescriptor
    {
        public EditorSelectionEditorDescriptor()
        {
            ClientEditingClass = "alloy/editors/AutoSuggestEditor";
        }

        public override void ModifyMetadata(Shell.ObjectEditing.ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            base.ModifyMetadata(metadata, attributes);

            metadata.EditorConfiguration["storeurl"] = VirtualPathUtility.ToAbsolute("~/api/authors/");
        }
    }
}