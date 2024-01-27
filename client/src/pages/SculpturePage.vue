<template>
    <div class="container-fluid">
        <div class="row">
            <div class="col-12 mb-3 d-flex flex-column align-items-center">
                <p class="fs-1 text-center">{{ sculpture.name }}</p>
                <div v-if="images.length > 0" class="position-relative">
                    <!-- Image Content -->
                    <div v-for="(image, index) in images" :key="image.id">
                        <img :class="index == currentImgIndex ? 'd-block' : 'hidden'"
                            class="fit-contain mvh-100 w-100 rounded" :src="image.imageUrl"
                            :alt="`Picture of ${sculpture.name}`">
                    </div>
                    <!-- Default Image Nav -->
                    <div v-if="images.length > 1" class="scroll-container fs-1 text-shadow">
                        <div @click="scrollImg(-1)" role="button" class="justify-content-start">
                            <i class="mdi mdi-hand-pointing-left"></i>
                        </div>
                        <div @click="scrollImg(1)" role="button" class="justify-content-end">
                            <i class="mdi mdi-hand-pointing-right"></i>
                        </div>
                    </div>
                </div>
                <!-- Default If no Image Data -->
                <img v-else class="fit-contain mvh-100 w-100 rounded" :src="sculpture.coverImg"
                    :alt="`Picture of ${sculpture.name}`">
                <!-- Mini Image Nav -->
                <div v-if="images.length > 1" class="mini-img-container">
                    <div v-for="(image, index) in images" :key="image.id">
                        <img role="button" @click="setImg(index)"
                            :class="index == currentImgIndex ? 'border-secondary box-shadow' : 'border-primary'"
                            class="mini-img" :src="image.imageUrl" :alt="`Picture of ${sculpture.name}`">
                    </div>
                </div>
            </div>
            <!-- Image Info -->
            <div class="col-12 col-md-2 order-1 order-md-0 fs-6">
                <p>Made in: {{ sculpture.year }}</p>
                <p v-if="sculpture.dimensions">{{ sculpture.dimensions }}</p>
                <div v-if="sculpture.price">
                    <button class="btn btn-secondary">${{ sculpture.price }}</button>
                    <p class="fs-7">*Contact me if you're interested in purchasing!</p>
                </div>
                <p v-else>Sculpture is not for sale</p>
            </div>
            <div class="col-12 col-md-10 order-0 order-md-1 border-secondary">
                <p class="fs-5">{{ sculpture.description }}</p>
            </div>
        </div>
    </div>
</template>


<script>
import { onMounted, ref } from 'vue';
import Pop from '../utils/Pop';
import { sculpturesService } from '../services/SculpturesService';
import { imagesService } from '../services/ImagesService';
import { useRoute } from 'vue-router';
import { logger } from '../utils/Logger';

export default {
    setup() {
        // VARIABLES
        const sculpture = ref({})
        const images = ref([])
        const currentImgIndex = ref(0)
        const route = useRoute()
        // FUNCTIONS
        async function getThisSculpture() {
            try {
                sculpture.value = await sculpturesService.getSculptureById(route.params.id)
            } catch (err) {
                Pop.error(err)
            }
        }
        async function getThisImages() {
            try {
                images.value = await imagesService.getImagesBySculptureId(route.params.id)
            } catch (err) {
                Pop.error(err)
            }
        }
        function scrollImg(amount) {
            currentImgIndex.value += amount

            if (currentImgIndex.value == -1) {
                currentImgIndex.value = images.value.length - 1
            } else if (currentImgIndex.value == images.value.length) {
                currentImgIndex.value = 0
            }
        }
        function setImg(index) {
            currentImgIndex.value = index
        }
        // LIFECYCLE
        onMounted(() => {
            getThisSculpture()
            getThisImages()
        })
        return { sculpture, images, currentImgIndex, scrollImg, setImg }
    }
};
</script>


<style lang="scss" scoped>
.border-secondary {
    border-left: solid 1px;
}

.scroll-container {
    display: flex;
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    color: white;
}

.scroll-container>div {
    display: flex;
    align-items: center;
    padding: 0 .5em 0 .5em;
    width: 100%;
    height: 100%;
}

.mini-img {
    transition: ease-in-out .2s;
    max-width: 10vh;
    border: solid 4px;
    border-radius: 7px;
    aspect-ratio: 1/1;
    margin: .5em;
}

.mini-img-container {
    display: flex;
    align-items: start;
    justify-content: start;
    overflow-x: scroll;
    max-width: 100vw;
}

.mini-img-container::-webkit-scrollbar {
    display: none;
}


.mini-img-container {
    -ms-overflow-style: none;
    scrollbar-width: none;
}
</style>