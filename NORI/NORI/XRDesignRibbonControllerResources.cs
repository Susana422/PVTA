using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace NORI
{
    internal class XRDesignRibbonControllerResources
    {
        private static ResourceManager resourceMan;

        private static CultureInfo resourceCulture;

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (resourceMan == null)
                {
                    ResourceManager resourceManager = new ResourceManager("Nori.XRDesignRibbonControllerResources", typeof(XRDesignRibbonControllerResources).Assembly);
                    resourceMan = resourceManager;
                }
                return resourceMan;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        internal static Bitmap RibbonUserDesigner_AlignBottom
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_AlignBottom", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_AlignHorizontalCenters
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_AlignHorizontalCenters", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_AlignLeft
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_AlignLeft", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_AlignRight
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_AlignRight", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_AlignToGrid
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_AlignToGrid", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_AlignTop
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_AlignTop", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_AlignVerticalCenters
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_AlignVerticalCenters", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_BackColor
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_BackColor", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_BringToFront
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_BringToFront", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_CenterHorizontally
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_CenterHorizontally", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_CenterVertically
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_CenterVertically", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_Copy
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_Copy", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_CopyLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_CopyLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_Cut
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_Cut", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_CutLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_CutLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_Edit
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_Edit", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_Exit
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_Exit", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_ExitLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_ExitLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_Font
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_Font", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_FontBold
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_FontBold", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_FontItalic
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_FontItalic", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_FontUnderline
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_FontUnderline", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_ForeColor
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_ForeColor", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_HorizSpaceConcatenate
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_HorizSpaceConcatenate", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_HorizSpaceDecrease
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_HorizSpaceDecrease", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_HorizSpaceIncrease
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_HorizSpaceIncrease", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_HorizSpaceMakeEqual
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_HorizSpaceMakeEqual", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_HtmlBackward
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_HtmlBackward", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_HtmlBackwardLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_HtmlBackwardLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_HtmlFind
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_HtmlFind", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_HtmlFindLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_HtmlFindLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_HtmlForward
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_HtmlForward", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_HtmlForwardLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_HtmlForwardLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_HtmlHome
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_HtmlHome", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_HtmlHomeLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_HtmlHomeLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_HtmlRefresh
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_HtmlRefresh", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_HtmlRefreshLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_HtmlRefreshLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_HtmlStop
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_HtmlStop", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_HtmlStopLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_HtmlStopLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_JustifyCenter
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_JustifyCenter", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_JustifyJustify
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_JustifyJustify", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_JustifyLeft
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_JustifyLeft", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_JustifyRight
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_JustifyRight", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_NewReport
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_NewReport", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_NewReportLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_NewReportLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_NewReportWizard
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_NewReportWizard", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_NewReportWizardLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_NewReportWizardLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_OpenFile
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_OpenFile", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_OpenFileLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_OpenFileLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_Paste
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_Paste", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_PasteLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_PasteLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_Redo
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_Redo", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_RedoLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_RedoLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_Report
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_Report", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_SaveAll
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_SaveAll", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_SaveAllLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_SaveAllLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_SaveFile
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_SaveFile", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_SaveFileAs
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_SaveFileAs", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_SaveFileAsLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_SaveFileAsLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_SaveFileLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_SaveFileLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_Scripts
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_Scripts", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_ScriptsLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_ScriptsLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_SendToBack
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_SendToBack", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_SizeToControl
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_SizeToControl", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_SizeToControlHeight
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_SizeToControlHeight", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_SizeToControlWidth
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_SizeToControlWidth", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_SizeToGrid
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_SizeToGrid", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_Undo
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_Undo", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_UndoLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_UndoLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_VertSpaceConcatenate
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_VertSpaceConcatenate", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_VertSpaceDecrease
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_VertSpaceDecrease", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_VertSpaceIncrease
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_VertSpaceIncrease", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_VertSpaceMakeEqual
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_VertSpaceMakeEqual", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_Windows
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_Windows", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_WindowsLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_WindowsLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_Zoom
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_Zoom", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_ZoomIn
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_ZoomIn", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_ZoomInLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_ZoomInLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_ZoomLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_ZoomLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_ZoomOut
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_ZoomOut", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal static Bitmap RibbonUserDesigner_ZoomOutLarge
        {
            get
            {
                object @object = ResourceManager.GetObject("RibbonUserDesigner_ZoomOutLarge", resourceCulture);
                return (Bitmap)@object;
            }
        }

        internal XRDesignRibbonControllerResources()
        {
        }
    }
}
