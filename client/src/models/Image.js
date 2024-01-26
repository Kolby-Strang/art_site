export class Image {
    constructor(data) {
        this.id = data.id
        this.createdAt = data.createdAt
        this.updatedAt = data.updatedAt
        this.imageUrl = data.imageUrl
        this.sculptureId = data.sculptureId
    }
}