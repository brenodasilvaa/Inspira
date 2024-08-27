'use client'; // Mark this as a Client Component

import React from 'react';
import { Card, CardHeader, Button, Avatar, Box, CardContent, CardActionArea, CardMedia, Grid, Typography, Icon } from '@mui/material';
import CommentIcon from '@mui/icons-material/Comment';

interface ImageCardProps {
    title: string;
    description: string;
    imageUrl: string;
  }

const Post: React.FC<ImageCardProps> = ({ title, description, imageUrl }) => {

  const handleClick = () => {
    console.log('Card clicked!');
  };

  return (
    <Card sx={{alignContent:'center'}}>
      <CardHeader
        avatar={
          <Avatar alt="User Photo" src={imageUrl} />
        }
        title="Breno"
        subheader="September 14, 2016"
      />
      <CardContent sx={{display:'flex', flexDirection:'row'}} onClick={handleClick}>
      <Grid alignContent={'center'} container spacing={0.5}>
        <Grid xs={12} sm={6} md={6} lg={6} item>
        <CardMedia>
          {
            true ? (
              <video style={{objectFit:'cover', height:'60vh', width:'100%'}} controls>
              <source src="https://www.w3schools.com/html/mov_bbb.mp4" type="video/mp4" />
              Your browser does not support the video tag.
            </video>
            ) :
            <img src={imageUrl} alt={title} style={{ width: '100%', height: 'auto', objectFit:'cover' }} />
          }
        
      </CardMedia>
          <CardContent>
            <Typography variant="body2">{title}</Typography>
            <Typography variant="subtitle2" color="text.secondary">{description}</Typography>
          </CardContent>

        </Grid>

        <Grid xs={12} sm={6} md={6} lg={6} item>
        <CardMedia>
        {
            false ? (
              <video width="100%" height="300vw" controls>
              <source src="https://www.w3schools.com/html/mov_bbb.mp4" type="video/mp4" />
              Your browser does not support the video tag.
            </video>
            ) :
            <img src={'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25'} alt={title} style={{ width: '100%', height:'60vh', objectFit:'cover'}} />
          }
      </CardMedia>
          <CardContent>
          <Typography variant="body2">{title}</Typography>
          <Typography variant="subtitle2" color="text.secondary">{description}</Typography>
          </CardContent>
        </Grid>
      </Grid>
      </CardContent>
      <CardContent>
      <Typography variant="body2">TESTESTESTE</Typography>
      </CardContent>
    </Card>
  );
};

export default Post;