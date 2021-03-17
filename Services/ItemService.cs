using MassTransit;
// ... imports
public class ItemService : IItemService {
    private readonly IPublishEndpoint _publish;
    public ItemService(InventoryContext ctx, IPublishEndpoint publish) {
        _ctx = ctx;
        _publish = publish;
    }
    public async void Add(Item i) {
        _ctx.Items.Add(i);
        _ctx.SaveChanges();
        await _publish.Publish(new { Id = i.Id, Name = i.Name });
    }
}