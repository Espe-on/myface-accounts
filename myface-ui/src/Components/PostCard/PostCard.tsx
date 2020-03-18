import React from "react";
import {Card} from "../Card/Card";
import "./PostCard.scss";
import {Link} from "react-router-dom";
import {Post} from "../../Models/Interfaces/Post";

interface PostCardProps {
    post: Post;
}

export function PostCard(props: PostCardProps): JSX.Element {
    return (
        <Card>
            <div className="post-card">
                <img className="image" src={props.post.imageUrl} alt=""/>
                <div className="message">{props.post.message}</div>
                <div className="user">
                    <img className="profile-image" src={props.post.postedBy.profileImageUrl} alt=""/>
                    <Link className="user-name" to={`/users/${props.post.postedBy.id}`}>{props.post.postedBy.displayName}</Link>
                </div>
            </div>
        </Card>
    );
}