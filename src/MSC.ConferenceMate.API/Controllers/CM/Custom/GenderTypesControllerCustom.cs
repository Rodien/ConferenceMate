// <auto-generated> - Template:WebApiControllerPartialMethods, Version:1.1, Id:54f0612b-5235-437d-af2d-0b75efa68630
using CodeGenHero.Repository;
using System.Data.Entity;
using System.Linq;
using entCM = MSC.ConferenceMate.Repository.Entities.CM;

namespace MSC.ConferenceMate.API.Controllers.CM
{
	public partial class GenderTypesCMController : CMBaseApiControllerAuthorized
	{

		//partial void RunCustomLogicAfterInsert(ref entCM.GenderType newDBItem, ref IRepositoryActionResult<entCM.GenderType> result) {}

		//partial void RunCustomLogicAfterUpdatePatch(ref entCM.GenderType updatedDBItem, ref IRepositoryActionResult<entCM.GenderType> result) {}

		partial void RunCustomLogicAfterUpdatePut(ref entCM.GenderType updatedDBItem, ref IRepositoryActionResult<entCM.GenderType> result)
		{
			if (result.Status == Enums.RepositoryActionStatus.NotFound)
			{	// An update/PUT was attempted when it should have been a create/POST.
				var localDBItem = updatedDBItem;
				var insertResult = Utils.AsyncHelper.RunSync<IRepositoryActionResult<entCM.GenderType>>(() => Repo.InsertAsync(localDBItem));
				if (insertResult.Status == Enums.RepositoryActionStatus.Created)
				{   // Insert worked
					result = new RepositoryActionResult<entCM.GenderType>(insertResult.Entity, Enums.RepositoryActionStatus.Updated);
				}
			}
		}

		// partial void RunCustomLogicBeforeUpdatePut(ref entCM.GenderType updatedDBItem, int genderTypeId)
		// {
		// 	var existingDBItem = Utils.AsyncHelper.RunSync<entCM.GenderType>(() => Repo.Get_GenderTypeAsync(genderTypeId, 1));
		// 	if (existingDBItem != null)
		// 	{	// Do not allow the user to change the "MySpecialField" value.
		// 		updatedDBItem.MySpecialField = existingDBItem.MySpecialField;
		// 	}
		// }

		///// <summary>
		///// A sample implementation of custom logic used to either manipulate a DTO item or include related entities.
		///// </summary>
		///// <param name="dbItem"></param>
		///// <param name="id"></param>
		///// <param name="numChildLevels"></param>
		// partial void RunCustomLogicOnGetEntityByPK(ref entCM.GenderType dbItem, int genderTypeId, int numChildLevels)
		// {
			// if (numChildLevels > 1)
			// {
				// int[] orderLineItemIds = dbItem.OrderLineItems.Select(x => x.OrderLineItemId).ToArray();

				// var lineItemDiscounts = Repo.CMDataContext.OrderLineItemDiscounts.Where(x => orderLineItemIds.Contains(x.OrderLineItemId)).ToList();

				// foreach (var lineItemDiscount in lineItemDiscounts)
				// { // Find the match and add the item to it.
					// var orderLineItem = dbItem.OrderLineItems.Where(x => x.OrderLineItemId == lineItemDiscount.OrderLineItemId).FirstOrDefault();

					// if (orderLineItem == null)
					// {
						// throw new System.Data.Entity.Core.ObjectNotFoundException($"Unable to locate matching OrderLineItem record for {lineItemDiscount.OrderLineItemId}."
					// }

					// orderLineItem.LineItemDiscounts.Add(lineItemDiscount);
				// }
			// }

		// }

		///// <summary>
		///// A sample implementation of custom logic used to filter on a field that exists in a related, parent, table.
		///// </summary>
		///// <param name="dbItems"></param>
		///// <param name="filterList"></param>
		//partial void RunCustomLogicAfterGetQueryableList(ref IQueryable<entCM.GenderType> dbItems, ref List<string> filterList)
		//{
		//	var queryableFilters = filterList.ToQueryableFilter();
		//	var myFilterCriterion = queryableFilters.Where(y => y.Member.ToLowerInvariant() == "<myFieldName>").FirstOrDefault(); // Examine the incoming filter for the presence of a field name which does not exist on the target entity.

		//	if (myFilterCriterion != null)
		//	{   // myFieldName is a criterion that has to be evaluated at a level other than our target entity.
		//		dbItems = dbItems.Include(x => x.myFKRelatedEntity).Where(x => x.myFKRelatedEntity.myFieldName == new Guid(myFilterCriterion.Value));
		//		queryableFilters.Remove(myFilterCriterion);  // The evaluated criterion needs to be removed from the list of filters before we invoke the ApplyFilter() extension method.
		//		filterList = queryableFilters.ToQueryableStringList();
		//	}
		//}
	}
}
