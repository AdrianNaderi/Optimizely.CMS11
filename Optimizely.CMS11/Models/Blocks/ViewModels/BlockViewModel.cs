namespace Optimizely.CMS11.Models.Blocks.ViewModels
{
    public class BlockViewModel
    {
        
    }

    public class BlockViewModel<T> : BlockViewModel
    {
        public T CurrentBlock { get; set; }
        public BlockViewModel(T block)
        {
            CurrentBlock = block;
        }
    }
}