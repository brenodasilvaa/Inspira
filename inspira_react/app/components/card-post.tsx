'use client'; // Mark this as a Client Component

import React from 'react';
import { Card, CardHeader, Button, Avatar, Box, CardContent, CardActionArea, CardMedia, Grid, Typography, Icon, useTheme, useMediaQuery } from '@mui/material';
import CommentIcon from '@mui/icons-material/Comment';
import { useRouter } from 'next/navigation';

interface ImageCardProps {
    title: string;
    description: string;
    imageUrl: string;
  }

const CardPost: React.FC<ImageCardProps> = ({ title, description, imageUrl }) => {

  const navigate = useRouter();
  const theme = useTheme();
  const isSmallScreen = useMediaQuery(theme.breakpoints.down('sm'));

  const handleClick = () => {
    navigate.push('/post-detail');
  };

  return (
    <Card sx={{minHeight:'50vh', maxHeight:'50vh', padding:'10px', width:isSmallScreen ? '80vw' : '40vw'}}>
      <CardHeader
        avatar={
          <Avatar alt="User Photo" src={imageUrl} />
        }
        title="Breno"
        subheader="September 14, 2016"
        action={
          <div>3 <CommentIcon></CommentIcon></div>
          
        }
      />
      <CardActionArea onClick={handleClick}>
      <Grid container spacing={0.5}>
        <Grid item xs={6}>
          <CardMedia
            component="img"
            image= {imageUrl}
            alt="First Image"
            style={{ height: '100px', objectFit: 'cover' }}
          />
          <CardContent>
            <Typography variant="body2">{title}</Typography>
            <Typography variant="subtitle2" color="text.secondary">{description}</Typography>
          </CardContent>

        </Grid>

        <Grid item xs={6}>
          <CardMedia
            component="img"
            image= {imageUrl}
            alt="Second Image"
            style={{ height: '100px', objectFit: 'cover' }}
          />
          <CardContent>
          <Typography variant="body2">{title}</Typography>
          <Typography variant="subtitle2" color="text.secondary">{description}</Typography>
          </CardContent>
        </Grid>
      </Grid>
      </CardActionArea>
    </Card>
  );
};

export default CardPost;