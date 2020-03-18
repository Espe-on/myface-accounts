export interface ListResponse<T> {
    items: T[];
    totalNumberOfItems: number;
    page: number;
    nextPage: string;
    previousPage: string;
}