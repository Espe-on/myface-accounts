﻿export async function fetchPostsLikedBy(page: number, pageSize: number, userId: string | number) {
    const response = await fetch(`https://localhost:5001/feed?page=${page}&pageSize=${pageSize}&likedBy=${userId}`);
    return await response.json();
}