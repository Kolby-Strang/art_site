<template>
    <div class="container-fluid border-secondary px-0 position-relative">
        <router-link :to="`sculpture/${sculpture.id}`" class="h-100 hover">
            <FastImage :_id="sculpture.id" :_class="'aspect-1-1 img-fluid fit-cover rounded'" :_src="sculpture.coverImg"
                :_alt="sculpture.name"></FastImage>
            <div class="fw-bold text-shadow text-white cover">
                <p class="reveal cover-title mb-0 fs-4 w-75">{{ sculpture.name }}</p>
                <p class="reveal cover-year mb-0">{{ sculpture.year }}</p>
            </div>
        </router-link>
    </div>
</template>


<script>
import { Sculpture } from '../models/Sculpture';
import FastImage from './FastImage.vue';

export default {
    props: {
        sculpture: { type: Sculpture, required: true }
    },
    setup() {
        return {}
    },
    components: { FastImage }
};
</script>


<style lang="scss" scoped>
.container-fluid {
    border-radius: 6px;
    border: solid .5px;
}

.cover {
    display: flex;
    position: absolute;
    bottom: 0;
    width: 100%;
    height: 100%;
    align-items: end;
    justify-content: space-between;
    padding: 0 .5em .25em .5em;
}

.reveal {
    transition: ease-in-out .2s;
    opacity: 0;
}

.hover:hover {
    .reveal {
        opacity: 1;
    }
}
</style>