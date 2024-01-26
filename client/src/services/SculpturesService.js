import { Sculpture } from "../models/Sculpture"
import { logger } from "../utils/Logger"
import { api } from "./AxiosService"

class SculpturesService {
    async getNewestSculpture() {
        const res = await api.get('api/sculptures')
        res.data = res.data.map((pojo) => new Sculpture(pojo))
        const sculptures = res.data.sort((a, b) => b.id - a.id)
        return sculptures[0]
    }
}

export const sculpturesService = new SculpturesService()