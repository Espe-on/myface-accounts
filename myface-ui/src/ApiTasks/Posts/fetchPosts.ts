import {ListResponse} from "../../Models/Interfaces/ListResponseT";
import {Post} from "../../Models/Interfaces/Post";

export async function fetchPosts(page: number, pageSize: number): Promise<ListResponse<Post>> {
    const response = await fetch(`https://localhost:5001/feed?page=${page}&pageSize=${pageSize}`);
    return await response.json();
}