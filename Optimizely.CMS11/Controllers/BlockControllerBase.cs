using System.Web.Mvc;
using EPiServer.Core;
using EPiServer.Web.Mvc;
using Optimizely.CMS11.Models.Blocks.ViewModels;

namespace Optimizely.CMS11.Controllers
{
    public class BlockControllerBase<TBlock> : BlockController<TBlock>
        where TBlock : BlockData
    {
        protected ActionResult PageView(BlockViewModel<TBlock> viewModel)
        {
            return PartialView($"~/Views/Blocks/{typeof(TBlock).Name}.cshtml", viewModel);
        }
    }
}