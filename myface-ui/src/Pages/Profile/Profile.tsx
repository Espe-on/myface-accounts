﻿import React from "react";
import { useParams } from 'react-router-dom'; 
import {Page} from "../Page/Page";
import {UserDetails} from "../../Components/UserDetails/UserDetails";
import {PostList} from "../../Components/PostList/PostList";
import "./Profile.scss";
import {fetchPostsLikedBy} from "../../ApiTasks/Posts/fetchPostsLikeBy";
import {fetchPostsDislikedBy} from "../../ApiTasks/Posts/fetchPostsDislikedBy";
import {fetchPostsForUser} from "../../ApiTasks/Posts/fetchPostsForUser";

export function Profile(): JSX.Element {
    const {id} = useParams();
    
    return (
        <Page containerClassName="profile">
            <UserDetails userId={id!!}/>
            <div className="activity">
                <PostList title="Posts" fetchPosts={() => fetchPostsForUser(1, 12, id!!)}/>
                <PostList title="Likes" fetchPosts={() => fetchPostsLikedBy(1, 12, id!!)}/>
                <PostList title="Dislikes" fetchPosts={() => fetchPostsDislikedBy(1, 12, id!!)}/>
            </div>
        </Page>
    );
}