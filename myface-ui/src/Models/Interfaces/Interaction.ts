import {User} from "./User";

export interface Interaction {
    id: number;
    user: User;
    type: string;
    date: string;
}