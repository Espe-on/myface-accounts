import {ListResponse} from "../../Models/Interfaces/ListResponseT";
import {User} from "../../Models/Interfaces/User";

export async function fetchUsers(searchTerm: string, page: number, pageSize: number): Promise<ListResponse<User>> {
    const response = await fetch(
        `https://localhost:5001/users
        ?search=${searchTerm}
        &page=${page}
        &pageSize=${pageSize}`);
    return await response.json();
}