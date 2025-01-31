﻿using Microsoft.EntityFrameworkCore;

namespace Moongazing.Kernel.Persistence.Paging;

public static class QueryablePaginateExtensions
{
    public static async Task<IPagebale<T>> ToPaginateAsync<T>(
        this IQueryable<T> source,
        int index,
        int size,
        int from = 0,
        CancellationToken cancellationToken = default
    )
    {
        if (from > index)
            throw new ArgumentException($"From: {from} > Index: {index}, must from <= Index");

        int count = await source.CountAsync(cancellationToken).ConfigureAwait(false);

        List<T> items = await source.Skip((index - from) * size).Take(size).ToListAsync(cancellationToken).ConfigureAwait(false);

        Pagebale<T> list =
            new()
            {
                Index = index,
                Size = size,
                From = from,
                Count = count,
                Items = items,
                Pages = (int)Math.Ceiling(count / (double)size)
            };
        return list;
    }

    public static IPagebale<T> ToPaginate<T>(this IQueryable<T> source, int index, int size, int from = 0)
    {
        if (from > index)
            throw new ArgumentException($"From: {from} > Index: {index}, must from <= Index");

        int count = source.Count();
        var items = source.Skip((index - from) * size).Take(size).ToList();

        Pagebale<T> list =
            new()
            {
                Index = index,
                Size = size,
                From = from,
                Count = count,
                Items = items,
                Pages = (int)Math.Ceiling(count / (double)size)
            };
        return list;
    }
}