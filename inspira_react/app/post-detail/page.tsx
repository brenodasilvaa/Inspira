'use client';

import React from 'react';
import { Grid, Box, ThemeProvider, useMediaQuery, useTheme, TextField, Typography } from '@mui/material';
import CardPost from '../components/card-post';
import Post from '../components/post';
import AlignItemsList from '../components/comment-list';
import Cards from '../components/cards';

const PostDetailPage = () => {
  const theme = useTheme();
  const isSmallScreen = useMediaQuery(theme.breakpoints.down('sm'));
  return (
    <Box sx={{ flexGrow: 1, marginTop:10  }}>
    <Grid padding={1} container spacing={2} direction={isSmallScreen ? 'column' : 'row'}>
      <Grid item xs={12} sm={5} sx={{ flexBasis: isSmallScreen ? '100%' : '60%' }}>
      <Post 
                    title={'title'} 
                    description={'card.description'} 
                    imageUrl={'card.imageUrl'} 
                  />
      </Grid>
      
      <Grid spacing={1} item xs={12} sm={7} sx={{ flexBasis: isSmallScreen ? '100%' : '40%' }}>
      <TextField multiline sx={{backgroundColor:'Background', borderRadius:'4px', width:'100%', marginBottom:'1vh'}} label="Comentar" variant="outlined" />
      <AlignItemsList>
                    
        </AlignItemsList>
        
      </Grid>
      <Box sx={{display:'flex', justifyContent:'center', textAlign:'center', width:'100%', marginTop:'10vh', marginBottom:'-5vh'}}>
      <Typography padding={2} variant="body1">Veja posts relacionados</Typography>

      </Box>
    </Grid>
    
    <Cards></Cards>
  </Box>
  );
};

export default PostDetailPage;
