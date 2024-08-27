'use client';

import React from 'react';
import { Grid, Box, ThemeProvider } from '@mui/material';
import CardPost from '../components/card-post';
import Post from '../components/post';

const cardsData = [
  { id: 1, title: 'First Image', description: 'Info about the first image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 2, title: 'Second Image', description: 'Info about the second image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 3, title: 'Third Image', description: 'Info about the third image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 4, title: 'Fourth Image', description: 'Info about the fourth image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 5, title: 'Fourth Image', description: 'Info about the fourth image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 4, title: 'Fourth Image', description: 'Info about the fourth image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 4, title: 'Fourth Image', description: 'Info about the fourth image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 4, title: 'Fourth Image', description: 'Info about the fourth image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 4, title: 'Fourth Image', description: 'Info about the fourth image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 4, title: 'Fourth Image', description: 'Info about the fourth image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' }
];

const PostDetailPage = () => {
  return (
      <Box sx={{ width:1, marginTop:10 }}>
                  <Post 
                    title={'title'} 
                    description={'card.description'} 
                    imageUrl={'card.imageUrl'} 
                  />
        </Box>  
  );
};

export default PostDetailPage;
