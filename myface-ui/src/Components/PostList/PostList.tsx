import React, {useEffect, useState} from 'react';
import {Grid} from "../Grid/Grid";
import {PostCard} from "../PostCard/PostCard";
import {ListResponse} from "../../Models/Interfaces/ListResponseT";
import {Post} from "../../Models/Interfaces/Post";

interface PostListProps {
    title: string,
    fetchPosts: () => Promise<ListResponse<Post>>
}

export function PostList(props: PostListProps): JSX.Element {
    const [posts, setPosts] = useState<Post[]>([]);
    
    useEffect(() => {
        props.fetchPosts()
            .then(response => setPosts(response.items));
    }, [props]);
    
    return (
        <section>
            <h2>{props.title}</h2>
            <Grid>
                {posts.map(post => <PostCard key={post.id} post={post}/>)}
            </Grid>
        </section>
    );
}